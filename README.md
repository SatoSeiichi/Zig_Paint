# Zig_Paint

# プロジェクトについて

ZigSimアプリを使ったお絵描きツールっぽいプロトタイプ　プロジェクト

# 動作環境 

Unity5.5.0

OSX 10.11

# 事前準備

・！！プロジェクトをダウンロードしたら、下記のアセットを必ずインポートしてください　インポートしないと動きません！！
Animated Line Renderer
https://www.assetstore.unity3d.com/jp/#!/content/55222

・スマホにZigSimアプリを入れる　　http://zig-project.com/

・PCとスマホを同じWifiにつなげる

・ZigSimアプリのSettingsタブをタップし、

　[IP ADDRESS]をPCが繋がっているIP ADDRESSと合わせる
 
　[PROTOCOL]をUDPに変更
 
　[DATE DESTINATION　]をOTHER APP　に変更

　[PORT NUMBER]を　50000 に変更(Unity側でも変えれます)

　[MESSAGE FORMAT]を JSON　に変更

・ZigSimアプリのSensorタブをタップし、

　２D　TOUCHをタップしチェックをつける

# 動作確認

・paint_zigシーン　を開く
 
 ・hierarchy上のManagerオブジェクトにアタッチされているZigRecieverのport noでUnity上のPORT NUMBERを変更することが可能です　デフォルト 50000
 
 ・unityをplayし　ZigSimアプリのStartタブをタップし画面をなぞって線が出れば成功です
 
 
