unit uBubbleSort;

interface

uses
  Generics.Collections, System.Classes, System.SysUtils, System.SyncObjs;

  type
  TBubbleSortThread = class(TThread)
  private
    FStartIndex, FEndIndex: Integer;
    FListInt: TList<Integer>;
  protected
    procedure Execute; override;
  public
    constructor Create(StartIndex, EndIndex: Integer; listInt: TList<Integer>);
  end;

  function MultithreadedBubbleSort(const ArrString: string; NumThreads: Integer): TList<Integer>;

implementation

const
  ArraySize = 5;

var
  Arr: array of Integer;

constructor TBubbleSortThread.Create(StartIndex, EndIndex: Integer; listInt: TList<Integer>);
begin
  inherited Create(True);
  FStartIndex := StartIndex;
  FEndIndex := EndIndex;
  FListInt := listInt;
end;

procedure TBubbleSortThread.Execute;
var
  i, temp: Integer;
begin
    for i := 0 to Length(Arr) - 2 do
    begin
      if Terminated then
        Exit;

      if Arr[i] > Arr[i + 1] then
      begin
        temp := Arr[i];
        Arr[i] := Arr[i + 1];
        Arr[i + 1] := temp;
      end;
    end;
end;

function MultithreadedBubbleSort(const ArrString: string; NumThreads: Integer): TList<Integer>;
var
  Threads: array of TBubbleSortThread;
  i, j, chunkSize: Integer;
  temp: Integer;
  SortedList: TList<Integer>;
  values: TStringList;
begin
  SortedList := TList<Integer>.Create;

  values := TStringList.Create;
  values.CommaText := ArrString;

  SetLength(Arr, values.Count);

  for i := 0 to values.Count - 1 do
  begin
    Arr[i] := StrToInt(values[i]);
  end;

  try

    SetLength(Threads, NumThreads);
    chunkSize := Length(Arr) div NumThreads;

    for i := 0 to NumThreads - 1 do
    begin
      if i = NumThreads - 1 then
        Threads[i] := TBubbleSortThread.Create(i * chunkSize, SortedList.Count - 1, SortedList)
      else
        Threads[i] := TBubbleSortThread.Create(i * chunkSize, (i + 1) * chunkSize - 1, SortedList);

      Threads[i].Start;
    end;

    for i := 0 to NumThreads - 1 do
      Threads[i].WaitFor;

    for i := 0 to Length(Arr) - 1 do
      SortedList.Add(Arr[i]);

    Result := SortedList;
  except
    on E: Exception do
    begin
      SortedList.Free;
      raise;
    end;
  end;
end;

end.
