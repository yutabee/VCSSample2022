namespace Chap11_EventInit;

// SampleEventHandlerという名前のデリゲートを定義
delegate void SampleEventHandler();

// イベントを発生させるクラス
class TestClass
{
    // 匿名メソッドを使ってeventのthreeEventを初期化
    public event SampleEventHandler ThreeEvent = delegate { };

    // ラムダ式を使った場合
    // public event SampleEventHandler threeEvent = () => {};

    // 1～20を表示。ただし、3の倍数のときはイベントを発生させる
    public void OnThreeEvent()
    {
        for (int i = 1; i <= 20; i++)
        {
            Console.WriteLine(i);
            if (i % 3 == 0)
            {
                ThreeEvent();
            }
        }
    }
}
class EventInit
{
    public static void Main()
    {
        var t = new TestClass();
        
        // イベントハンドラーを追加
        t.ThreeEvent += delegate { Console.WriteLine("××"); };

        // ラムダ式を使った場合
        // t.threeEvent += ( ) => Console.WriteLine( "××" );

        // イベントが発生する処理
        t.OnThreeEvent();
    }
}
