using DDD.WinForm.Common;
using System.Data;
using System.Data.SQLite;

namespace DDD.WinForm.Data
{
    public static class WetherSQLite
    {
        public static DataTable SearchLatest(int areaId)
        {
            string sql = @"select 
                                DataDate,
                                Condition,
                                Temperature  
                            from 
                                Weather 
                            where 
                                AreaId = @AreaId
                            order by 
                                DataDate desc
                            limit 1";

            DataTable dt = new DataTable();
            using (var connection = new SQLiteConnection(CommonConst.ConnectionString))
            using (var command = new SQLiteCommand(sql, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@AreaId", areaId);

                using (var adapter = new SQLiteDataAdapter(command))
                {
                    adapter.Fill(dt);
                }
            }

            return dt;
        }
    }
}
