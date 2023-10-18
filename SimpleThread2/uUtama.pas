unit uUtama;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Vcl.StdCtrls, System.SyncObjs,
  Vcl.ExtCtrls;

type
  TPrimeCheckerThread = class
  private
    FStart, FEnd: Integer;
    FListBox: TListBox;
  public
    constructor Create(Start, Stop: Integer; ListBox: TListBox);
    procedure Execute;
  end;

  TForm2 = class(TForm)
    ListBox1: TListBox;
    ListBox2: TListBox;
    ListBox3: TListBox;
    btnExecutePrime: TButton;
    ListBox4: TListBox;
    Panel1: TPanel;
    procedure btnExecutePrimeClick(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form2: TForm2;

implementation

{$R *.dfm}

{ TPrimeCheckerThread }

constructor TPrimeCheckerThread.Create(Start, Stop: Integer; ListBox: TListBox);
begin
  FStart := Start;
  FEnd := Stop;
  FListBox := ListBox;
end;

function IsPrime(num: Integer): Boolean;
var
  i: Integer;
begin
  if num < 2 then
    Result := False
  else
  begin
    Result := True;
    for i := 2 to Trunc(Sqrt(num)) do
    begin
      if (num mod i) = 0 then
      begin
        Result := False;
        Break;
      end;
    end;
  end;
end;

procedure TPrimeCheckerThread.Execute;
var
  i: Integer;
begin
  for i := FStart to FEnd do
  begin
    if IsPrime(i) then
    begin
      TThread.Synchronize(nil,
        procedure
        begin
          FListBox.Items.Add(IntToStr(i));
        end
      );
    end;
  end;
end;

procedure TForm2.btnExecutePrimeClick(Sender: TObject);
var
  Thread1, Thread2, Thread3, Thread4: TPrimeCheckerThread;
  UpperLimit: Integer;
begin
  ListBox1.Clear;
  ListBox2.Clear;
  ListBox3.Clear;
  ListBox4.Clear;

  UpperLimit := 10000; // Define your upper limit here

  Thread1 := TPrimeCheckerThread.Create(2, UpperLimit div 4, ListBox1);
  Thread2 := TPrimeCheckerThread.Create(2, UpperLimit div 4, ListBox2);
  Thread3 := TPrimeCheckerThread.Create(2, UpperLimit div 4, ListBox3);
  Thread4 := TPrimeCheckerThread.Create(2, UpperLimit div 4, ListBox4);

  TThread.CreateAnonymousThread(
    procedure
    begin
      Thread1.Execute;
    end
  ).Start;

  TThread.CreateAnonymousThread(
    procedure
    begin
      Thread2.Execute;
    end
  ).Start;

  TThread.CreateAnonymousThread(
    procedure
    begin
      Thread3.Execute;
    end
  ).Start;

  TThread.CreateAnonymousThread(
    procedure
    begin
      Thread4.Execute;
    end
  ).Start;
end;

end.
