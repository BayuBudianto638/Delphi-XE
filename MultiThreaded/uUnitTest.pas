unit uUnitTest;

interface
uses
  DUnitX.TestFramework, Generics.Collections, uBubbleSort;

type
  [TestFixture]
  TestTBubbleSort = class(TObject)
  public
    [Test]
    procedure TestBubbleSort;
  end;

implementation

procedure TestTBubbleSort.TestBubbleSort;
var
  ExpectedArr : TArray<Integer>;
  Arr : TList<Integer>;
  ArrString : string;
begin
  Arr := TList<Integer>.Create;
  ArrString := '0,3,1,2';

  ExpectedArr := [0,1,2,3];
  Arr := MultithreadedBubbleSort(ArrString, 4);
  Assert.AreEqual(ExpectedArr, Arr.ToArray, 'True');
end;

initialization
  TDUnitX.RegisterTestFixture(TestTBubbleSort);

end.
