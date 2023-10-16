object Form2: TForm2
  Left = 0
  Top = 0
  Caption = 'Simple Thread Apps'
  ClientHeight = 217
  ClientWidth = 404
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'Tahoma'
  Font.Style = []
  OldCreateOrder = False
  PixelsPerInch = 96
  TextHeight = 13
  object edtPrimeX: TEdit
    Left = 56
    Top = 16
    Width = 121
    Height = 21
    TabOrder = 0
  end
  object edtPrimeY: TEdit
    Left = 202
    Top = 16
    Width = 121
    Height = 21
    TabOrder = 1
  end
  object btnProcess: TButton
    Left = 152
    Top = 162
    Width = 75
    Height = 25
    Caption = 'Go'
    TabOrder = 2
    OnClick = btnProcessClick
  end
  object listX: TListBox
    Left = 56
    Top = 43
    Width = 121
    Height = 97
    ItemHeight = 13
    TabOrder = 3
  end
  object listY: TListBox
    Left = 202
    Top = 43
    Width = 121
    Height = 97
    ItemHeight = 13
    TabOrder = 4
  end
end
