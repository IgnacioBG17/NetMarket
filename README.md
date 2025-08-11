# Servicio BackeEnd Ecommerce - Programador

Este proyecto consiste en una aplicación BackeEnd para un Ecommerce.

---

## 🧩 Tecnologías utilizadas

- **Backend:** ASP.NET Core Web API (.NET 8)
- **ORM:** Entity Framework Core
- **Base de datos:** SQL Server
- **Repositorio:** GitHub público

---

## 📁 Estructura del proyecto

```
NetMarket/
│
├── WebApi/                  # Proyecto API REST
│   ├── Controllers/         # Producto, Marca y Categoria
│   ├── Dtos/                # Clases para retornar al cliente
│   └── Error/               # Mensajes de error
│   └── Middleware/          # ExceptionMiddleware
│
├── BusinessLogic/           # Proyecto ClassLibrary
│   ├── CargaData/           # JSON Categoria, Marca y Producto
│	├── Data/                # JSON Categoria, Marca y Producto
│	├── Logic/               # JSON Categoria, Marca y Producto
│
├── Core/                    # Proyecto ClassLibrary
│
└── README.md
```

---

## 🔌 Funcionalidades implementadas

- CRUD de Categorías
- CRUD de Productos
- Relación 1:N entre Categoría y Producto
- Filtros por nombre y código
- Pruebas con Postman
---

## ▶️ Instrucciones para correr el proyecto

### Backend
1. Ingresar a la ruta
 ```bash
   cd NetMarket
   ```
2. Restaurar paquetes:

   ```bash
   dotnet restore
   ```

3. Crear base de datos:

   ```bash
   dotnet ef database update
   ```

4. Ejecutar API:

   ```bash
   dotnet run
   ```

5. Acceder a Swagger:

   ```
   https://localhost:<puerto>/swagger
   ```
---

## 🌐 Repositorio

Este proyecto fue subido a GitHub como parte proyectos personales.  
🔗 [https://github.com/tu-IgnacioBG17/](https://github.com/IgnacioBG17/)

---

## 📞 Contacto

Desarrollado por: **[Angel Bustamante]**  
Correo: [bustamanteangel532@gmail.com]  

---

## ✅ Resultado esperado

> Se entrega una solución funcional, bien estructurada.
