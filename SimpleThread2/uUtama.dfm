object Form2: TForm2
  Left = 0
  Top = 0
  Caption = 'Form MultiThread'
  ClientHeight = 417
  ClientWidth = 536
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'Tahoma'
  Font.Style = []
  OldCreateOrder = False
  PixelsPerInch = 96
  TextHeight = 13
  object ListBox1: TListBox
    Left = 8
    Top = 104
    Width = 257
    Height = 137
    ItemHeight = 13
    TabOrder = 0
  end
  object ListBox2: TListBox
    Left = 271
    Top = 104
    Width = 257
    Height = 137
    ItemHeight = 13
    TabOrder = 1
  end
  object ListBox3: TListBox
    Left = 8
    Top = 256
    Width = 257
    Height = 137
    ItemHeight = 13
    TabOrder = 2
  end
  object btnExecutePrime: TButton
    Left = 453
    Top = 73
    Width = 75
    Height = 25
    Caption = 'Execute'
    TabOrder = 3
    OnClick = btnExecutePrimeClick
  end
  object ListBox4: TListBox
    Left = 271
    Top = 256
    Width = 257
    Height = 137
    ItemHeight = 13
    TabOrder = 4
  end
  object Panel1: TPanel
    Left = 8
    Top = 8
    Width = 520
    Height = 59
    Caption = 
      'Display Multithreaded Prime Number simultanously in every ListBo' +
      'x'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -13
    Font.Name = 'Tahoma'
    Font.Style = [fsBold]
    ParentFont = False
    TabOrder = 5
  end
end
