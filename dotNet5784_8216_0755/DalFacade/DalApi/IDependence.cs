﻿
namespace DalApi;
using DO;
public interface IDependence
{
    int Create(Dependence item); //Creates new entity object in DAL
    Dependence? Read(int id); //Reads entity object by its ID 
    List<Dependence> ReadAll(); //stage1 only, Reads all entity objects
    void Update(Dependence item); //Updates entity object
    void Delete(int id); //Deletes an object by its Id
}
