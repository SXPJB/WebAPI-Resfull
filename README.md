# WebAPI-Resfull
Implementacion de servicios REST con Asp.net core 3.1

#
Rutas de consumo
#Agregar
/api/Cliente/Agregar
{
  "id": int,
  "nombre": "string",
  "apellido": "string"
}
#Optener todos
/api/Cliente
Retorna lista de objetos
[{
  "id": int,
  "nombre": "string",
  "apellido": "string"
},{
  "id": int,
  "nombre": "string",
  "apellido": "string"
}...{
  "id": int,
  "nombre": "string",
  "apellido": "string"
}]
Optener por id
/api/Cliente/{id}
