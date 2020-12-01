# WebAPI-Resfull
Implementacion de servicios REST con Asp.net core 3.1

#
Rutas de consumo
#
Agregar
/api/Cliente/Agregar<br>
{<br>
  "id": int,<br>
  "nombre": "string",<br>
  "apellido": "string"<br>
}
#
Optener todos<br>
/api/Cliente<br>
Retorna lista de objetos<br>
[{<br>
  "id": int,<br>
  "nombre": "string",<br>
  "apellido": "string"<br>
},{<br>
  "id": int,<br>
  "nombre": "string",<br>
  "apellido": "string"<br>
}...{<br>
  "id": int,<br>
  "nombre": "string",<br>
  "apellido": "string"<br>
}]<br>
Optener por id<br>
/api/Cliente/{id}
