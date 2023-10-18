unit uUtama;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants,
  System.Classes, Vcl.Graphics, Vcl.Controls, Vcl.Forms, Vcl.Dialogs,
  Vcl.StdCtrls, uBubbleSort, Generics.Collections, Vcl.ExtCtrls;

type
  TfrmSort = class(TForm)
    edtBubbleSort: TEdit;
    btnBubbleSort: TButton;
    memBubbleSort: TMemo;
    Panel1: TPanel;
    procedure btnBubbleSortClick(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  frmSort: TfrmSort;

implementation

{$R *.dfm}

procedure TfrmSort.btnBubbleSortClick(Sender: TObject);
var
  i: Integer;
  inputText: string;
  listInt : TList<Integer>;
begin
  listInt := TList<Integer>.Create;

  inputText := edtBubbleSort.Text;

  try
    listInt := MultithreadedBubbleSort(inputText, 4);

    memBubbleSort.Lines.Clear;
    for i := 0 to listInt.Count - 1 do
      memBubbleSort.Lines.Add(IntToStr(listInt[i]));

  finally
    listInt.Free;
  end;
end;

end.
