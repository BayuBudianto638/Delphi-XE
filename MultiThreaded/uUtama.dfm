object frmSort: TfrmSort
  Left = 0
  Top = 0
  BorderIcons = [biSystemMenu, biMinimize]
  Caption = 'Form Sort with Multithreaded'
  ClientHeight = 441
  ClientWidth = 594
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'Tahoma'
  Font.Style = []
  OldCreateOrder = False
  Position = poScreenCenter
  PixelsPerInch = 96
  TextHeight = 13
  object edtBubbleSort: TEdit
    Left = 42
    Top = 77
    Width = 422
    Height = 21
    TabOrder = 0
  end
  object btnBubbleSort: TButton
    Left = 470
    Top = 73
    Width = 75
    Height = 25
    Caption = 'Bubble Sort'
    TabOrder = 1
    OnClick = btnBubbleSortClick
  end
  object memBubbleSort: TMemo
    Left = 42
    Top = 104
    Width = 503
    Height = 297
    TabOrder = 2
  end
  object Panel1: TPanel
    Left = 42
    Top = 8
    Width = 503
    Height = 59
    Caption = 'Bubble Sort menggunakan Multithreading'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -21
    Font.Name = 'Tahoma'
    Font.Style = [fsBold]
    ParentFont = False
    TabOrder = 3
  end
end
