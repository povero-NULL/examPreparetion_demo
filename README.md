# examPreparetion_demo
試験対策アプリデモ版

## Home.cs
アプリを開いて最初に表示される画面。
ログイン画面に遷移する。

## Login.cs
アプリにログインするための画面。
未着手。

## QuestionForm.cs
問題を出すための画面。
上部に問題、下部に1～4の番号と解答が表示される。

Back：ひとつ前の問題に戻る。(未着手）
Next：正解を確認し次の問題に映る。(未着手）

## Program.cs
メイン処理を実施。
Homeの表示。

## Process.cs
QuestionFormでの処理を担当。

# Questionクラス
questionStatement：問題文
answer1：解答①
answer2：解答②
answer3：解答③
answer4：解答④
correctAnswer：正解番号

# Question LoadQuestion(int questionId)
テキストファイルから問題を読み込み、Question型リストに保存