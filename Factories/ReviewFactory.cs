
// using System.Collections.Generic;
// using System.Linq;
// using Dapper;
// using System.Data;
// using MySql.Data.MySqlClient;
// using Entity.Models;
// using Microsoft.Extensions.Options;
// using System;

// namespace Entity.Factory
// {

//     public class ReviewFactory : IFactory<Review>
//     {
//         private MySqlOptions _options;

//         public ReviewFactory(IOptions<MySqlOptions> config)
//         {
//             _options = config.Value;
//         }
//         internal IDbConnection Connection

//         {
            
//             get
//             {
                
//                 return new MySqlConnection(_options.Connect);
//             }
//         }


//         public IEnumerable<Review> FindAll()
//         {
//             using (IDbConnection dbConnection= Connection)
//             {
//                 dbConnection.Open();
//                 return dbConnection.Query<Review>("SELECT * FROM Reviews");
//             }
//         }



//     }

// }