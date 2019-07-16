using System;
using System.Collections.Generic;
using System.Data;
using burgershack.Models;
using Dapper;

namespace burgershack.Repositories
{
    public class SideRepository
    {
        private readonly IDbConnection _db;
        public SideRepository(IDbConnection db)
        {
            _db = db;
        }
        public IEnumerable<Side> GetAll()
        {
            return _db.Query<Side>("SELECT * FROM sides");
        }

        public Side GetById(int id)
        {
            string query = "SELECT * FROM sides WHERE id = @id";
            Side data = _db.QueryFirstOrDefault<Side>(query, new { id });
            if (data == null) throw new Exception("Invalid Id"); //throw creates a new exception
            return data;
        }

        public Side Create(Side value)
        {
            string query = @"INSERT INTO sides (name, description) VALUES (@Name, @Description); 
                            SELECT LAST_INSERT_ID();";
            int id = _db.ExecuteScalar<int>(query, value);
            value.Id = id;
            return value;
        }

        public Side Update(Side value)
        {
            string query = @"
                UPDATE sides
                SET
                    name = @Name,
                    description = @Description
                WHERE id = @Id;
                SELECT * FROM sides WHERE id = @Id
            ";
            return _db.QueryFirstOrDefault<Side>(query, value);
        }

        public string Delete(int id)
        {
            string query = "DELETE FROM sides WHERE id = @id";
            int changedRows = _db.Execute(query, new { id });
            if (changedRows < 1) throw new Exception("Invalid Id");
            return "Sucessfully Deleted Side";
        }
    }
}