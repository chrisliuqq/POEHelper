POEHelper
=========

A macro to send oos, itemlevel, remaining

雖然用 autokey 之類的按鍵精靈就可以達成…
不過還是自己寫了一個 poe 巨集

執行檔：https://dl.dropboxusercontent.com/u/209570/POE/POEHelper.7z
原始碼：https://github.com/chrisliuqq/POEHelper

測試環境：win7 64bit，.net Framework 4.5 以上

--
```
F2：/oos
F3：/remaining
F4：/itemlevel
```
--

100% 測試過（在我的電腦上）

--

###已知 feature

雖然 code 裡面有 findwindow 但實際上根本沒透過 win32api 去抓 hwnd，而是直接送出 key 給前景，
所以如果你開著這個程式在筆記本上按 F2 的話，就會吐 /oos 給你看
沒有人會在前景不是 POE 的時候又想打 oos 吧…

--

設定按鍵、自訂字串什麼的太麻煩了，有機會可以發到 github issue 或是留言給我，但是我不一定會改…（咦咦）
