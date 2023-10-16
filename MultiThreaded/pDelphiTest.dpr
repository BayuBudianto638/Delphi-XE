program pDelphiTest;

uses
  Vcl.Forms,
  uUtama in 'uUtama.pas' {frmSort},
  uBubbleSort in 'Sort\uBubbleSort.pas';

{$R *.res}

begin
  Application.Initialize;
  Application.MainFormOnTaskbar := True;
  Application.CreateForm(TfrmSort, frmSort);
  Application.Run;
end.
