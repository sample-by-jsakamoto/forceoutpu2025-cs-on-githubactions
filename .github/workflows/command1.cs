// index.html をテキストとして読み取り...
var indexHtml = File.ReadAllText("./public/index.html");
// <base href="/"> を <base href="/my-repo/" /> に置換して..
indexHtml = indexHtml.Replace("<base href=\"/\" />", "<base href=\"/my-repo/\" />");
// index.html に書き戻し
File.WriteAllText("./public/index.html", indexHtml);