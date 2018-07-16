namespace EF_Mutiple_Dev_Migration_Demo
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class MigrationDBContext : DbContext
    {
        // 您的內容已設定為使用應用程式組態檔 (App.config 或 Web.config)
        // 中的 'MigrationDBContext' 連接字串。根據預設，這個連接字串的目標是
        // 您的 LocalDb 執行個體上的 'EF_Mutiple_Dev_Migration_Demo.MigrationDBContext' 資料庫。
        // 
        // 如果您的目標是其他資料庫和 (或) 提供者，請修改
        // 應用程式組態檔中的 'MigrationDBContext' 連接字串。
        public MigrationDBContext()
            : base("name=MigrationDBContext")
        {
        }
        public virtual DbSet<Book> Book { get; set; }
    }
}