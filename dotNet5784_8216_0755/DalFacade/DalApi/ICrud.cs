﻿using DO;
namespace DalApi;
/// <summary>
/// GEneric interface to the data entitys
/// </summary>
public interface ICrud<T> where T : class
{
    int Create(T item); //Creates new entity object in DAL
    T? Read(int id); //Reads entity object by its ID 
    T? Read(Func<T, bool> filter); //Reads entity object by a parameter
    IEnumerable<T?> ReadAll(Func<T, bool>? filter = null);//Reads all entity objects according to a parameter
    void Update(T item); //Updates entity object
    void Delete(int id); //Deletes an object by its Id
}
