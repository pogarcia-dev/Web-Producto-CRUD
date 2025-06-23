# Sistema Web CRUD MVC + DAO (.NET Framework)

Aplicación web de ejemplo, desarrollada con fines académicos, que implementa un CRUD completo siguiendo el patrón de diseño **MVC** (Modelo-Vista-Controlador) y la capa de acceso a datos **DAO** (Data Access Object) sobre **C#** y **.NET Framework**.

## 📋 Descripción

Este proyecto está organizado para separar de forma clara:

- **Modelo**: Clases POCO (Plain Old CLR Object) en C# que representan las tablas de la base de datos.
- **Vista**: Páginas Razor para la interfaz de usuario.
- **Controlador**: Clases cuyas acciones responden a solicitudes HTTP, validan entrada y orquestan la lógica.
- **DAO**: Clases encargadas de realizar operaciones CRUD (Create, Read, Update, Delete) usando ADO.NET.

## ⚙️ Tecnologías y herramientas

- Lenguaje: **C#** (versión .NET Framework 4.7)
- IDE: **Visual Studio 2022**
- Servidor web: **IIS Express** (integrado en Visual Studio)
- Base de datos: **SQL Server**
- Data Access: **ADO.NET** puro (sin Entity Framework)
- Control de versiones: **Git**

## ✨ Características

- Listado completo de productos  
- Alta, baja y modificación de productos  
- Validación básica de formularios (cliente y servidor)  
- Manejo de mensajes de éxito y error  
- Diseño basado en MVC + DAO  

## 🚀 Instalación y uso

1. **Clonar el repositorio**  
   ```bash
   git clone https://github.com/pogarcia-dev/Web-Producto-CRUD.git
   cd Web-Producto-CRUD
   ```

2. **Configurar la base de datos**

   * Ejecuta el script SQL descrito más abajo para crear la base de datos, las tablas y los datos iniciales.

3. **Abrir la solución en Visual Studio**

   * En Visual Studio, selecciona **Archivo → Abrir → Proyecto/Solución** y carga el archivo `.sln`.

4. **Restaurar paquetes NuGet**

   * En el **Explorador de soluciones**, haz clic derecho sobre la solución y elige **Restaurar paquetes NuGet**.

5. **Ejecutar la aplicación**

   * Presiona **F5** para compilar y desplegar en IIS Express.
   * Abre tu navegador en `http://localhost:xxxxx` (la ruta y puerto aparecen en la barra de IIS Express).

## 📝 Script SQL Base

```sql
-- Crear la base de datos
CREATE DATABASE BD_Producto;
GO

-- Usar la base de datos recién creada
USE BD_Producto;
GO

-- Crear la tabla Categoria
CREATE TABLE Categoria (
    ID INT IDENTITY(1,1) PRIMARY KEY,    -- ID como clave primaria y autoincrementable
    Nombre VARCHAR(100) NOT NULL         -- Nombre de la categoría, no puede ser nulo
);
GO

-- Crear la tabla Producto con FK a Categoria
CREATE TABLE Producto (
    ID INT IDENTITY(1,1) PRIMARY KEY,            -- ID como clave primaria y autoincrementable
    Descripcion VARCHAR(255) NOT NULL,           -- Descripción del producto
    IdCategoria INT NOT NULL,                    -- FK a Categoria.ID
    Precio DECIMAL(10, 2) NOT NULL,              -- Precio del producto
    Stock INT CONSTRAINT DF_Producto_Stock DEFAULT 0,  -- Stock con valor por defecto 0
    CONSTRAINT FK_Producto_Categoria FOREIGN KEY (IdCategoria) REFERENCES Categoria(ID)
);
GO

-- Insertar datos en la tabla Categoria
INSERT INTO Categoria (Nombre) VALUES
('Ropa'),
('Calzado'),
('Accesorios');
GO

-- Insertar datos en la tabla Producto
INSERT INTO Producto (Descripcion, IdCategoria, Precio, Stock) VALUES
('Camiseta de Algodón',         1, 15.99, 50),
('Jeans de Corte Slim',         1, 39.99, 35),
('Zapatos Deportivos',          2, 59.99, 25),
('Bolso de Mano de Cuero',      3, 89.99, 15),
('Sombrero de Paja',            3, 12.99, 40),
('Chaqueta de Invierno',        1,120.00, 30),
('Pantalones Cortos',           1, 22.50, 60),
('Tennis Running',              2, 45.00, 10),
('Sandalias de Playa',          2, 18.99, 80),
('Camiseta con Logo',           1, 25.00, 20),
('Mochila de Nylon',            3, 35.00, 50),
('Bufanda de Lana',             3, 19.99, 45),
('Chaqueta de Cuero',           1,150.00, 20),
('Gafas de Sol',                3, 40.00, 25),
('Pantalón de Chándal',         1, 28.99, 30),
('Reloj de Pulsera',            3,110.00, 10),
('Cinturón de Cuero',           3, 25.50, 55),
('Sudadera con Capucha',        1, 35.99, 40),
('Polo de Algodón',             1, 19.99, 75),
('Chaleco de Abrigo',           1, 49.99, 20),
('Guantes de Invierno',         3, 15.00, 30),
('Camiseta de Manga Larga',     1, 18.99, 60),
('Taco Alto de Cuero',          2, 85.00, 12),
('Botines de Cuero',            2,110.00,  8),
('Chaqueta Impermeable',        1, 95.00, 25),
('Zapatillas de Casa',          2, 12.00, 70),
('Falda de Cuero',              1, 50.00, 18),
('Botas de Montaña',            2,120.00, 10),
('Camiseta Deportiva',          1, 29.99, 55),
('Mochila Escolar',             3, 25.00, 45),
('Bermuda de Playa',            1, 20.00, 60);
GO
```

## 🎓 Qué aprenderás

* Organizar un proyecto web en C# con separación de capas.
* Implementar operaciones CRUD sobre SQL Server usando DAO y ADO.NET.
* Configurar y desplegar una aplicación MVC en .NET Framework.


## 📄 Licencia

Este proyecto está bajo la licencia **MIT**. Consulta el archivo `LICENSE` para más detalles.