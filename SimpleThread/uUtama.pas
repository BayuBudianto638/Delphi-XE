unit uUtama;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Vcl.StdCtrls;

type
  TForm2 = class(TForm)
    edtPrimeX: TEdit;
    edtPrimeY: TEdit;
    btnProcess: TButton;
    listX: TListBox;
    listY: TListBox;
    procedure btnProcessClick(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

type
  TMyPrime = class(TThread)
  private
    numK: Integer;
    MyList: TlistBox;
  protected
    procedure Execute; override;
  public
    constructor Create(k : Integer; list: TListBox);
  end;

var
  Form2: TForm2;

implementation

{$R *.dfm}

constructor TMyPrime.Create(k : Integer; list: TListBox);
begin
  numK := k;
  MyList := list;
  FreeOnTerminate := True;
  inherited Create(False);
end;

procedure TMyPrime.Execute;
var
  i, j, k, x : Integer;
begin
  for i := 1 to numK do begin
        x := 0;
        for j := 1 to i do begin
            if (i mod j = 0) then
                x := x + 1;
        end;
        if (x = 2) then
            MyList.Items.Add(IntToStr(i));
  end;
end;

procedure TForm2.btnProcessClick(Sender: TObject);
var
  MyPrime: TMyPrime;
begin
  MyPrime := TMyPrime.Create(StrToInt(edtPrimeX.Text), listX);
  MyPrime := TMyPrime.Create(StrToInt(edtPrimeY.Text), listY);
end;

end.
