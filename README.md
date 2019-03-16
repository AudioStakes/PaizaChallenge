# 開発環境
・Microsoft Visual Studio Community for Mac 2017

# 環境構築手順

- プロジェクトにテキストファイルを追加する(sampleInput.txtとする)
  - プロジェクトを右クリック > 追加 > 新しい項目 > テキストファイル
- 追加したテキストファイルのプロパティを編集する
  - 「出力ディレクトリにコピー」の値を「常にコピーする」or「新しい場合はコピーする」にする
- コンパイラ設定の「シンボルの定義」に「LOCAL_DEBUG」を追加する
  - プロジェクトを右クリック > オプション > コンパイラ > シンボルの定義
- sampleInput.txtには、paizaで公開されているサンプル入力値をコピペしておいてください。

- 次のようなコードを利用
  - ローカルで実行するときは入力をファイルから受け取り
  - 提出時は普通に？入力値を受け取る
    - 提出時にコードを書き換えないで済む

```
namespace PaizaChallenge
{
  class Program
  {
    static void Main()
    {
      ChangeLocalDebugInput();

      // your code
      // ...
    }

    [System.Diagnostics.Conditional("LOCAL_DEBUG")]
    static void ChangeLocalDebugInput()
    {
      Console.SetIn(new System.IO.StreamReader("sampleInput.txt"));
    }
  }
}
```

# 色々トラブル解決法

### Macで実行してもコンソールに出力されないとき
- プロジェクト > PaizaChallengeオプション > 実行 > 構成 > Default
  - 「外部コンソールで実行する」のチェックを外す
  - 「コンソール出力を一時停止する」のチェックを外す

### パッケージの追加
- パッケージをクリック
- 追加したいパッケージを検索&追加
- 例
  - "using System.Text.RegularExpressions;"とファイル記述したら下記エラーが出たとき
  - "Error CS0234: The type or namespace name 'RegularExpressions' does not exist in the namespace 'System.Text' (are you missing an assembly reference?) (CS0234) (PaizaChallenge)"


# ショートカットキー
### 参考サイト
- https://docs.microsoft.com/ja-jp/visualstudio/mac/keyboard-shortcuts

### おすすめ
- ファイル スイッチャー
  - ファイルをすばやく切り替えることができます。
  - control + tab
- エディター内の行の移動
  - alt + up/down
- ワードのナビゲーション
  - カレットを次または前のワードに移動します。
  - option + left/right
- 行のナビゲーション
  - カレットを行頭または行末に移動します。
  - ⌘ + left/right
- 選択範囲の拡張
  - 論理的な方法でワード、サブ式、ステートメント、および行メンバーの選択を拡張します。
  - alt + shift + up で選択、alt + shift + down で選択解除されます
- クイック修正とクイック アクション
  - リファクタリング コンテキスト アクションが表示されます。
  - option + enter
