
    using System.Collections.Generic;
using System.Linq;

public class AlumnosService : IAlumnosService

    {
        private List<Alumno> list;

    public AlumnosService() 
        {
            list = new List<Alumno>();

            
            list.Add(new Alumno() 
            { 
                Id= 1, 
                Name = "Fernando", 
                Apellido = "De Sosa", 
                Edad = "19",
                
            });

            list.Add(new Alumno() 
            { 
                Id= 2, 
                Name = "Ana", 
                Apellido = "Robledo",
                Edad = "19", 
                  
            });

            list.Add(new Alumno() 
            { 
                Id= 3, 
                Name = "Dario", 
                Apellido = "Valdes", 
                Edad = "19",
  
            });
        }

        public List<Alumno> GetAll() 
        {
            return list;
        }

        public Alumno Get(int id) 
        {
            return list.FirstOrDefault(b => b.Id == id);
        }


        public void Save(Alumno alumnos)
        {
            this.Delete(alumnos.Id);
            list.Add(alumnos);
        }

        public void Delete(int id) 
        {
            var book = this.Get(id);

            if(book != null) 
            {
                list.Remove(book);
            }
        }

    List<Alumno> IAlumnosService.GetAll()
    {
        throw new System.NotImplementedException();
    }

    Alumno IAlumnosService.Get(int id)
    {
        throw new System.NotImplementedException();
    }

    public void Save(AlumnosService alumnos)
    {
        throw new System.NotImplementedException();
    }
}

