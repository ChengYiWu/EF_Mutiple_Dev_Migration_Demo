# EF_Mutiple_Dev_Migration_Demo


### EF 的 Code First 多人開發的 Migration 衝突解決
使用 `Add-Migration 'XXX' -IngoreChanges `


1. [a13f7e](https://github.com/ChengYiWu/EF_Mutiple_Dev_Migration_Demo/commit/a13f7e0a58007d4b50ba55ca5875d89c9840a8cd) Commit By Dev1 新增了一個 Field1 欄位

2. [006011](
https://github.com/ChengYiWu/EF_Mutiple_Dev_Migration_Demo/commit/0060110633a48f84772292d34b73722050563700) Commit By Dev2 新增了一個 Field2 欄位

3. [f81102](
https://github.com/ChengYiWu/EF_Mutiple_Dev_Migration_Demo/commit/f8110281be42976c43494ef93e3a3658b53379cb) Commit By Dev2 因為 Dev1 有新的 Commit (新增 Field1 的 Commit a13f7e0a58007d4b50ba55ca5875d89c9840a8cd)，故需先合併。
* 此時 Dev2 在 local 開發環境執行 `Update-Database` 可以正常運行，但執行程式會發現 EF 提示「目前 entity model 與 Migration 檔案的 snapshot 不一致，並請執行 `Update-Database`」，因為最後一次 Migration (增加 Filed2 的那個) 裡的 snapshot 的 entity model (Book) 只包含 Filed2，並沒有 Filed1。

4. [b10f4f](
https://github.com/ChengYiWu/EF_Mutiple_Dev_Migration_Demo/commit/b10f4fa177d3892eded0302d7a4a5538ac49a24f) Commit By Dev2 新增一個空的 Migration ，該檔案 snapshot 使用目前 entity model 狀態，所以 EF 就不會覺得目前 entity model 和 Migration 不一致

  `Add-Migration XXX -IgnoreChanges `

5. 這時 Dev2 local 環境就可以正常運行，Dev1 同樣正常。
