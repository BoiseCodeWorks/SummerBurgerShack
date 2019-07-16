using System;
using System.Collections.Generic;
using System.Data;
using burgershack.Models;
using Dapper;

namespace burgershack.Repositories
{
    public class BurgerRepository
    {
        private readonly IDbConnection _db;
        public BurgerRepository(IDbConnection db)
        {
            _db = db;
        }

        //GET ALL
        public IEnumerable<Burger> GetAllBurgers()
        {
            return _db.Query<Burger>("SELECT * FROM burgers");
        }

        public Burger GetBurgerById(int id)
        {
            string query = "SELECT * FROM burgers WHERE id = @id";
            Burger burger = _db.QueryFirstOrDefault<Burger>(query, new { id });
            if (burger == null) throw new Exception("Invalid Id"); //throw creates a new exception
            return burger;
        }

        public Burger CreateBurger(Burger value)
        {
            string query = @"INSERT INTO burgers (name, description, price) VALUES (@Name, @Description, @Price); 
                            SELECT LAST_INSERT_ID();";
            int id = _db.ExecuteScalar<int>(query, value);
            value.Id = id;
            return value;
        }

        public Burger UpdateBurger(Burger value)
        {
            string query = @"
                UPDATE burgers
                SET
                    name = @Name,
                    description = @Description,
                    price = @Price
                WHERE id = @Id;
                SELECT * FROM burgers WHERE id = @Id
            ";
            return _db.QueryFirstOrDefault<Burger>(query, value);
        }

        public string DeleteBurger(int id)
        {
            string query = "DELETE FROM burgers WHERE id = @id";
            int changedRows = _db.Execute(query, new { id });
            if (changedRows < 1) throw new Exception("Invalid Id");
            return "Sucessfully Deleted Burger";
        }
    }
}