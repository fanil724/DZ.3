using System.Data.SqlClient;


namespace DZ3.Model
{
    internal class VegetablesFruitsDBCLients
    {
        private DBManager manager;
        public VegetablesFruitsDBCLients(DBManager manager)
        {
            this.manager = manager;
        }

        public List<VegetablesFruits> SelectAll()
        {
            SqlConnection conn = null;
            SqlDataReader reader = null;
            List<VegetablesFruits> vegetablesFruits = new List<VegetablesFruits>();
            try
            {
                conn = manager.OpenDbConnection();
                string queryString = "SELECT * FROM VegetablesFruits";
                SqlCommand cmd = new SqlCommand(queryString, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    vegetablesFruits.Add(ReadVegetablesFruits(reader));
                }
                return vegetablesFruits;
            }
            finally
            {
                conn?.Close();
                reader?.Close();
            }
        }

        public List<string> SelectName()
        {
            SqlConnection conn = null;
            SqlDataReader reader = null;
            List<string> vegetablesFruits = new List<string>();
            try
            {
                conn = manager.OpenDbConnection();
                string queryString = "SELECT name as 'наименование:' FROM VegetablesFruits";
                SqlCommand cmd = new SqlCommand(queryString, conn);
                reader = cmd.ExecuteReader();
                vegetablesFruits.Add(reader.GetName(0));
                while (reader.Read())
                {
                    vegetablesFruits.Add(reader[0].ToString());
                }
                return vegetablesFruits;
            }
            finally
            {
                conn?.Close();
                reader?.Close();
            }
        }

        public List<string> SelectColor()
        {
            SqlConnection conn = null;
            SqlDataReader reader = null;
            List<string> vegetablesFruits = new List<string>();
            try
            {
                conn = manager.OpenDbConnection();
                string queryString = "SELECT DISTINCT color as 'цвет:' FROM VegetablesFruits";
                SqlCommand cmd = new SqlCommand(queryString, conn);
                reader = cmd.ExecuteReader();
                vegetablesFruits.Add(reader.GetName(0));
                while (reader.Read())
                {
                    vegetablesFruits.Add(reader[0].ToString());
                }
                return vegetablesFruits;
            }
            finally
            {
                conn?.Close();
                reader?.Close();
            }
        }

        public List<VegetablesFruits> MAXCalorie()
        {
            SqlConnection conn = null;
            SqlDataReader reader = null;
            List<VegetablesFruits> vegetablesFruits = new List<VegetablesFruits>();
            try
            {
                conn = manager.OpenDbConnection();
                string queryString = "SELECT * FROM VegetablesFruits WHERE Calorie=(SELECT max(Calorie) FROM VegetablesFruits)";
                SqlCommand cmd = new SqlCommand(queryString, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    vegetablesFruits.Add(ReadVegetablesFruits(reader));
                }
                return vegetablesFruits;
            }
            finally
            {
                conn?.Close();
                reader?.Close();
            }
        }

        public List<VegetablesFruits> MINCalorie()
        {
            SqlConnection conn = null;
            SqlDataReader reader = null;
            List<VegetablesFruits> vegetablesFruits = new List<VegetablesFruits>();
            try
            {
                conn = manager.OpenDbConnection();
                string queryString = "SELECT * FROM VegetablesFruits WHERE Calorie=(SELECT min(Calorie) FROM VegetablesFruits)";
                SqlCommand cmd = new SqlCommand(queryString, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    vegetablesFruits.Add(ReadVegetablesFruits(reader));
                }
                return vegetablesFruits;
            }
            finally
            {
                conn?.Close();
                reader?.Close();
            }
        }

        public List<string> SelectAVGCalorie()
        {
            SqlConnection conn = null;
            SqlDataReader reader = null;
            List<string> vegetablesFruits = new List<string>();
            try
            {
                conn = manager.OpenDbConnection();
                string queryString = "SELECT  AVG(Calorie) as 'сред калорийность:' FROM VegetablesFruits";
                SqlCommand cmd = new SqlCommand(queryString, conn);
                reader = cmd.ExecuteReader();
                vegetablesFruits.Add(reader.GetName(0));
                while (reader.Read())
                {
                    vegetablesFruits.Add(reader[0].ToString());
                }
                return vegetablesFruits;
            }
            finally
            {
                conn?.Close();
                reader?.Close();
            }
        }

        public List<string> SelectCntCVegetable()
        {
            SqlConnection conn = null;
            SqlDataReader reader = null;
            List<string> vegetablesFruits = new List<string>();
            try
            {
                conn = manager.OpenDbConnection();
                string queryString = "SELECT  COUNT(typeVF) as 'кол овощей:' FROM VegetablesFruits WHERE typeVF like 'овощ'";
                SqlCommand cmd = new SqlCommand(queryString, conn);
                reader = cmd.ExecuteReader();
                vegetablesFruits.Add(reader.GetName(0));
                while (reader.Read())
                {
                    vegetablesFruits.Add(reader[0].ToString());
                }
                return vegetablesFruits;
            }
            finally
            {
                conn?.Close();
                reader?.Close();
            }
        }

        public List<string> SelectCntFruit()
        {
            SqlConnection conn = null;
            SqlDataReader reader = null;
            List<string> vegetablesFruits = new List<string>();
            try
            {
                conn = manager.OpenDbConnection();
                string queryString = "SELECT  COUNT(typeVF) as 'кол фруктов:' FROM VegetablesFruits WHERE typeVF like 'фрукт'";
                SqlCommand cmd = new SqlCommand(queryString, conn);
                reader = cmd.ExecuteReader();
                vegetablesFruits.Add(reader.GetName(0));
                while (reader.Read())
                {
                    vegetablesFruits.Add(reader[0].ToString());
                }
                return vegetablesFruits;
            }
            finally
            {
                conn?.Close();
                reader?.Close();
            }
        }

        public List<string> SelectCntFruitAndVegetable(string color)
        {
            SqlConnection conn = null;
            SqlDataReader reader = null;
            List<string> vegetablesFruits = new List<string>();
            try
            {
                conn = manager.OpenDbConnection();
                string queryString = "SELECT  COUNT(*) as 'кол фруктов и овощей:' FROM VegetablesFruits WHERE color like @C";
                SqlCommand cmd = new SqlCommand(queryString, conn);
                cmd.Parameters.AddWithValue("@C", color);
                reader = cmd.ExecuteReader();
                vegetablesFruits.Add(reader.GetName(0));
                while (reader.Read())
                {
                    vegetablesFruits.Add(reader[0].ToString());
                }
                return vegetablesFruits;
            }
            finally
            {
                conn?.Close();
                reader?.Close();
            }
        }


        public List<string> SelectCntFruitAndVegetable()
        {
            SqlConnection conn = null;
            SqlDataReader reader = null;
            List<string> vegetablesFruits = new List<string>();
            try
            {
                conn = manager.OpenDbConnection();
                string queryString = "SELECT color as 'цвет',  COUNT(*) as 'кол фруктов и овощей:'\r\nFROM VegetablesFruits\r\nGROUP BY color";
                SqlCommand cmd = new SqlCommand(queryString, conn);
               
                reader = cmd.ExecuteReader();
                vegetablesFruits.Add(reader.GetName(0)+" - "+reader.GetName(1));
                while (reader.Read())
                {
                    vegetablesFruits.Add(reader[0]+" - " + reader[1]);
                }
                return vegetablesFruits;
            }
            finally
            {
                conn?.Close();
                reader?.Close();
            }
        }


        public List<VegetablesFruits> SelectLessCalories(int number)
        {
            SqlConnection conn = null;
            SqlDataReader reader = null;
            List<VegetablesFruits> vegetablesFruits = new List<VegetablesFruits>();
            try
            {
                conn = manager.OpenDbConnection();
                string queryString = "SELECT * FROM VegetablesFruits WHERE Calorie<@C";
                SqlCommand cmd = new SqlCommand(queryString, conn);
                cmd.Parameters.AddWithValue("@C", number);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    vegetablesFruits.Add(ReadVegetablesFruits(reader));
                }
                return vegetablesFruits;
            }
            finally
            {
                conn?.Close();
                reader?.Close();
            }
        }

        public List<VegetablesFruits> SelectMoreCalories(int number)
        {
            SqlConnection conn = null;
            SqlDataReader reader = null;
            List<VegetablesFruits> vegetablesFruits = new List<VegetablesFruits>();
            try
            {
                conn = manager.OpenDbConnection();
                string queryString = "SELECT * FROM VegetablesFruits WHERE Calorie>@C";
                SqlCommand cmd = new SqlCommand(queryString, conn);
                cmd.Parameters.AddWithValue("@C", number);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    vegetablesFruits.Add(ReadVegetablesFruits(reader));
                }
                return vegetablesFruits;
            }
            finally
            {
                conn?.Close();
                reader?.Close();
            }
        }

        public List<VegetablesFruits> SelecteCalories(int min, int max)
        {
            SqlConnection conn = null;
            SqlDataReader reader = null;
            List<VegetablesFruits> vegetablesFruits = new List<VegetablesFruits>();
            try
            {
                conn = manager.OpenDbConnection();
                string queryString = "SELECT * FROM VegetablesFruits WHERE Calorie>@MIN and Calorie<@MAX";
                SqlCommand cmd = new SqlCommand(queryString, conn);
                cmd.Parameters.AddWithValue("@MIN", min);
                cmd.Parameters.AddWithValue("@MAX", max);

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    vegetablesFruits.Add(ReadVegetablesFruits(reader));
                }
                return vegetablesFruits;
            }
            finally
            {
                conn?.Close();
                reader?.Close();
            }
        }


        public List<VegetablesFruits> SelectAllYEllowAndRed()
        {
            SqlConnection conn = null;
            SqlDataReader reader = null;
            List<VegetablesFruits> vegetablesFruits = new List<VegetablesFruits>();
            try
            {
                conn = manager.OpenDbConnection();
                string queryString = "SELECT * FROM VegetablesFruits WHERE color like 'желтый' or color like 'красный'";
                SqlCommand cmd = new SqlCommand(queryString, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    vegetablesFruits.Add(ReadVegetablesFruits(reader));
                }
                return vegetablesFruits;
            }
            finally
            {
                conn?.Close();
                reader?.Close();
            }
        }

        private VegetablesFruits ReadVegetablesFruits(SqlDataReader reader)
        {
            VegetablesFruits vf = new VegetablesFruits()
            {
                ID = reader.GetInt32(0),
                Name = reader.GetString(1),
                TypeVF = reader.GetString(2),
                Color = reader.GetString(3),
                Colorie = reader.GetInt32(4)
            };
            return vf;
        }
    }
}
