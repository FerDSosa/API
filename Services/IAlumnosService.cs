using System.Collections.Generic;

public interface IAlumnosService
    {
    List<Alumno> GetAll();

    Alumno Get(int id);
        void Save(Alumno alumno);
        void Delete(int id);
    }
