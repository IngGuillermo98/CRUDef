/*
==============================USAR EF===============================================
****************Con Usr y Contra*************************
Scaffold-DbContext "Server=TICHINSTRUCTOR;Database=InstitutoTich;User ID=sa;password=tich;" Microsoft.EntityFrameWorkCore.SqlServer -Tables "EstatusAlumnos" -Context DBContext -ContextDir Models/Context -OutputDir Models/Entities -NoPluralize -Force

****************Con Autenticacion de Win*************************
Scaffold-DbContext "Server=localhost;Database=LoteriaMexicana;integrated security=True;" Microsoft.EntityFrameWorkCore.SqlServer -Context DBContext -ContextDir Models/Context -OutputDir Models/Entities -NoPluralize -Force

********************************************************************************
https://learn.microsoft.com/es-es/ef/core/miscellaneous/connection-strings

*/

// ===========================================CONSULTAR 1===============================================
 public SiapTbCatAreas ConsultarUno(int id)
        {
            using (var db = _context)
            {
                var parametros = new List<SqlParameter>
        {
            new SqlParameter("@id", id)

        };
                var sql = "EXEC Consultar1 @id"; // Aqui ira el procedimiento
                return db.Set<SiapTbCatAreas>().FromSqlRaw(sql, parametros.ToArray()).AsEnumerable().FirstOrDefault();

            }
        }

// ===========================================INSERTAR===============================================
 public void Insertar(string variable1, string variable2)
        {
            using (var db = _context)
            {
                var parametros = new List<SqlParameter>
        {
            new SqlParameter("@variable1", variable1),
            new SqlParameter("@variable2", variable2)
        };

                var sql = "EXEC Insertar @variable1, @variable2";// con mas de un valor
                db.Database.ExecuteSqlRaw(sql, parametros.ToArray());
            }
        }

// mandar llamar al metodo
