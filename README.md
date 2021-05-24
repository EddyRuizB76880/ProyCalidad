
# Universidad de Costa Rica

# Documento de conceptualización

# EMPRENDE@UCR

# Version 1.0

[Referencia al control de versiones actual para el documento y el sistema](https://bitbucket.org/cristian_quesadalopez/ecci_ci0128_i2021_g01_pi/src/master/)

**Tabla de contenidos**

1. [Definiciones, acrónimos y abreviaciones](#Def)
2. [Introducción](#Intro)
3. [Listado de equipos y miembros](#Teams)
    - [Roles de iteración](#Roles)
4. [Descripción general del sistema a desarrollar](#id4)
    - [Contexto y situación actual](#Contexto)
    -  [Problema que resuelve](#Trouble)
    -  [Interesados del proyecto y tipos de usuarios](#Interesados)
    -  [Solución propuesta](#Solution)
    - [Análisis del entorno](#Anal)
    - [Visión del producto](#Vision)
    - [Relación con otros sistemas externos](#Relation)
    - [Descripción de los módulos y epics](#Epic)
    - [Requerimientos Funcionales](#Requirements)
    - [Product Road Map](#ProductRoadMap)
    - [Requerimientos no funcionales](#NonFuncRequirements)
5. [Artefactos de bases de datos](#ArtefactosBases)
    - [Esquema conceptual](#ERR)
    - [Esquema lógico](#Mapeo)
6. [Decisiones técnicas](#Decitions)
    - [Metodologías utilizadas](#Metodology)
    - [Artefactos utilizadas en el desarrollo](#Artefactos)
    - [Tecnologías utilizadas](#Tecnology)
    - [Repositorio de código & estrategia git](#Git)
    - [Definición de listo](#DOD)
7. [Referencias bibliográficas](#Ref)


## Definiciones, acrónimos y abreviaciones<a name="Def"></a>

## Introducción<a name="Intro"></a>

## Listado de equipos y miembros<a name="Teams"></a>

### Roles de iteración<a name="Roles"></a>

#### 3DKR:
    Rafael Porras       ->  Documentación
    Kevin Salas         ->  Look and feel
    Daniel Mayorga      ->  Scrum ambassador
    Dario Matamoros     ->  Bases de Datos
    Donaldo Salas       ->  Scrum master
    Andrés Chaves       ->  Estrategias Git

#### Phoenix:
    Alejandro Ramirez   ->  Documentación
    Luis Ureña          ->  Look and Feel
    Andres Zamora       ->  Scrum Master
    Hellen Fuentes      ->  Scrum ambassador
    Erick  Murillo      ->  Base de Datos
    Jean Carlo Quesada  ->  Estrategias Git

#### Pandemic:
    Manfred Carvajal    ->   Documentación
    Diego Barquero      ->   Look and feel
    Luis Rojas          ->   Scrum ambassador
    Jostyn Delgado      ->   Bases de Datos
    Isaac Herrera       ->   Scrum master/Documentación
    Johel Phillips      ->   Estrategias Git

#### F & ½L:
    Juan Valverde       ->   Scrum Master
    Herson Mena         ->   Bases de Datos
    Hansel Calderon     ->   Look and feel
    Sebastian Chavez    ->   Estrategias Git
    Silvia Aguilar      ->   Scrum Ambassador
    Eddy Ruiz           ->   Documentación

## Descripción general del sistema a desarrollar<a name="id4"></a>

### Contexto y situación actual<a name="Contexto"></a>

Debido a la pandemia por el coronavirus, existen muchas personas que se han quedado sin trabajo o no han podido hacer ventas de sus negocios. Por este motivo se decidió realizar una página web que permita a cualquier emprendedor promocionar y vender su producto o servicio.

### Problema que resuelve<a name="Trouble"></a>

Le permite a los emprendedores de cualquier tamaño dar a conocer sus productos y servicios permitiendo un canal comunicación entre el cliente y el emprendedor.

### Interesados del proyecto y tipos de usuarios<a name="Interesados"></a>

Los interesados del proyecto son los emprendedores que deseen vender su producto/servicio por medio de la página, así como los clientes que estén interesados en algún producto o servicio.

#### Tipos de Usuario:

*Emprendedor:* Perfil de la persona/empresa que vende servicios o productos.

*Cliente:* Perfil de la persona que desea comprar algún servicio o producto.

*Administrador:* El encargado de administrar la página web.


### Solución propuesta<a name="Solution"></a>

La solución propuesta es realizar una página web que permita tanto promocionar productos o servicios como realizar las compras dentro de la página. Además la página contará con un canal de comunicación directo(chat) entre cliente y emprendedor que permitirá que ambas partes se pongan de acuerdo en la orden y entrega del pedido/servicio. La app también permitirá crear alianzas entre emprendedores.


### Análisis del entorno<a name="Anal"></a>

### Visión del producto<a name="Vision"></a>

Para los emprendedores nacionales, quienes necesitan un medio para promocionar y vender sus productos y/o servicios, EMPRENDE@UCR es una plataforma web que permite la venta y compra en línea de productos y servicios. A diferencia de otras plataformas no enfocadas en los pequeños emprendedores, nuestro producto, además de ser gratuito, busca el crecimiento de los pequeños emprendedores y fomenta la cooperación entre estos.

### Relación con otros sistemas externos<a name="Relation"></a>

Los módulos del sistema web tiene relación con otros sistemas que ya existan.
ejemplo: la parte de los pagos, preguntar a la po si visualiza otros sistemas que quiera integrarle (facturas)


### Descripción de los módulos y epics<a name="Epic"></a>

Los módulos que fueron asignados a cada equipo son los siguientes: 

- **3DKR:** módulo de emprendedores
- **Pandemic:** módulo de usuarios y perfiles
- **F&½L:** módulo de gestión de pedidos y compras
- **Phoenix:** módulo de administración

#### Descripción de los módulos:

- **Emprendedores:** 

Consiste en todas las funcionalidades que puede realizar un emprendedor, principalmente registrar productos y servicios y formar alianzas con otros emprendedores 

- **Usuarios y perfiles:** 

Consiste en todo el proceso de creación y registro de un perfil ya sea de emprendedor o comprador, la autenticación de la cuenta y la autorización de las funcionalidades que tiene permitido realizar

- **Gestión de pedidos y compras:** 

Consiste en todo el proceso de compra de un producto o servicio, entre estos está el proceso de pago, seguimiento del producto, proceso de checkout y finalización de órdenes  
- **Administración:** 

Consiste en todo lo relacionado a administración, esto incluye la categorización y etiqueta de los diferentes productos y servicios disponibles además del chat entre los usuarios de la página 

#### Descripción de los epics:

- **Gestión de productos:** 

Poder agregar un producto o servicio para poder venderlo.

- **Registro de usuarios:** 

Poder crear y registrar una cuenta con perfil de emprendedor o comprador.

- **Pedidos en carrito de compras:**

Poder incluir en un carrito de compras una serie de productos o servicios (pero no ambos) de un mismo emprendedor y poder concluir esa compra con su respectivo pago.

- **Categorización de productos:** 

Poder categorizar y etiquetar productos o servicios.

#### Relación con los demás módulos: 

- **Relación módulo usuario y perfiles con módulo emprendedores**
    - Se relacionan directamente ya que es necesario que exista un usuario con perfil de emprendedor para poder realizar las funciones exclusivas de un emprendedor.

- **Relación módulo usuario y perfiles con módulo gestión de pedidos y compras**
    - Se relacionan directamente ya que es necesario que exista un usuario con perfil de comprador para poder realizar las compras de los productos o servicios de emprendedores.

- **Relación módulo usuario y perfiles con módulo administración**
    - Se relacionan directamente ya que el módulo de administración cumple con la funcionalidad de realizar reportes a los usuarios además de los métodos de pago de los usuarios y el chat entre usuario emprendedor y usuario comprador.

- **Relación módulo emprendedores con módulo gestión de pedidos y compras**
    - Se relacionan ya que los productos o servicios que los emprendedores suban a la página, el proceso de venta y pedidos de estos productos va a ser manejado por el módulo de pedidos y compras.

- **Relación módulo gestión de pedidos y compras con módulo administración**
    - El módulo de administración tiene la funcionalidad de los métodos de pago, por esto tiene relación directa con el modulo de gestion de pedidos y compras ya que es necesario conocer y poder realizar el pago del servicio o producto.

- **Relación módulo emprendedores con módulo administración**
    - Similar al punto anterior existe una relación directa entre estos módulos ya que se debe de tener conocimiento de cuáles son los métodos de pago que si son aceptados para un emprendedor en particular.

### Requerimientos Funcionales<a name="Requirements"></a>
Crear una plataforma virtual en linea donde emprendedores puedan juntarse con compradores y asi negociar entre ellos:

- Permitir el registro de distintos tipos de usuarios.(Administradores de sitio, compradores y emprendedores)

- Permitir a emprendedores registrar productos y servicios para publicarlos en la plataforma y generar mayor visibilidad.

- Permitir a los emprendedores generar alianzas con otros emprendedores.

- Permitir a emprendedores dar seguimiento a ordenes que hayan sido hechas por sus clientes.

- Permitir a compradores llenar un carrito de compras con productos o servicios (pero no ambos) de un mismo emprendedor.

- Permitir a compradores finalizar su compra por medio del paso de "checkout", donde puedan ver en una pantalla los contenidos del carrito de compra y el valor individual de cada uno, al igual del valor total de todo lo incluido en el carrito. En el checkout, debe haber un boton para confirmar la compra.

- Permitir a compradores elegir el metodo de pago que desean usar para finalizar su compra.

#### Referencia al proyecto de JIRA

Para poder acceder al [proyecto](http://10.1.4.22:8080/secure/RapidBoard.jspa?projectKey=PIIB12021&useStoredSettings=true&rapidView=43) el usuario necesita de acceso a un VPN para conectarse, así como acceso a un usuario y una contraseña.

### Product Road Map<a name="ProductRoadMap"></a> (Alejandro)

### Requerimientos no funcionales<a name="NonFuncRequirements"></a>

#### Eficiencia
- Toda funcionalidad del sistema debe responder al usuario en menos de 5 segundos
- Los datos modificados en la base de datos se deben ver reflejados en tiempo real para todos los usuarios.
- El sistema debe soportar una concurrencia de al menos X usuarios. (Validar con P.O)
#### Seguridad
- Los permisos del sistema solo pueden ser cambiados por un administrador.
- Se debe asegurar la privacidad de los datos sensibles del usuario.
#### Usabilidad
- El tiempo de aprendizaje del sistema por un usuario deberá ser menor a X tiempo. (Validar con el asesor)
- El sistema debe contar con un manual de usuario.
- El sistema debe proporcionar mensajes de error útiles para el usuario.
- La aplicación web debe garantizar la adecuada visualización en múltiples dispositivos (computadoras, teléfonos, tabletas, ...).
- El sistema debe poseer interfaces gráficas limpias e intuitivas.
#### Disponibilidad
- El sistema debe estar disponible el 99.981% del tiempo.


## Artefactos de bases de datos<a name="ArtefactosBases"></a>

### Esquema conceptual<a name="ERR"></a>

![Esquema conceptual de la base de datos](imgs/Conceptual_scheme.png)

Referencia al archivo fuente: [Esquema conceptual de la base de datos](https://lucid.app/lucidchart/521c91fc-fdbb-42cb-8564-09c0ab52c460/edit?page=0_0#)

### Esquema lógico<a name="Mapeo"></a>

![Esquema lógico de la base de datos](imgs/Logical_scheme.png)

Referencia al archivo fuente: [Esquema lógico de la base de datos](https://lucid.app/lucidchart/521c91fc-fdbb-42cb-8564-09c0ab52c460/edit?page=eAhCgoWCmbE2#)

## Decisiones técnicas<a name="Decitions"></a>

### Metodologías utilizadas<a name="Metodology"></a> (Alejandro)

### Artefactos utilizadas en el desarrollo<a name="Artefactos"></a>

**Product Backlog:**

Durante el sprint 0, se asignaron módulos a cada equipo de desarrolladores y a partir de los requerimientos de la P.O, se asignaron EPICS<a name="Epic"></a> e historias de usuario para cada equipo.

**Sprint Backlog:**

Según las tareas prioritarias del backlog, se realizó un product roadmap<a name="ProductRoadMap"></a> en el cuál seleccionaron historias de usuario.


### Tecnologías utilizadas<a name="Tecnology"></a>

#### Tecnologías de desarrollo

- **Blazor (Versión 5.0):** Framework enfocado en el desarrollo de aplicaciones web incorporado en .NET. Utiliza los lenguajes C# y HTML. 
- **ASP.NET (Versión 5.0):** Framework para el desarrollo de aplicaciones web.

#### Bases de datos

- **SQL Server 2016:** Lenguaje de bases de datos relacionales.
- **Microsoft SQL Server Management Studio 18:** Administrador de componentes dentro de SQL Server.

#### Administración

- **Bitbucket:** Sistema de alojamiento de proyectos que utiliza el sistema de control de versiones git.
- **Git:** Software de control de versiones (v2.31.1).
- **Jira:** Herramienta de administración de proyectos (v7.13.0).

#### Ambiente de desarrollo

- **Visual Studio:** Entorno de desarrollo integrado (IDE) (v16.9).


### Repositorio de código & estrategia git<a name="Git"></a>

#### Branches

- *Main*

- *Develop*

- *Team*

- *Feature*

De Feature a Team. PR, code review por una persona del team.

De Team a Develop. PR, review por 2 miembros de otros teams.

De Develop a Main. PR, review por los scrum ambassadors.

**DEVELOP -> MAIN**

- Asegurarse que main esta actualizado. Pull main.

- Asegurarse que develop esta actualizado. Merge main into develop.

- Corregir conflictos si los hay.

- Crear PR de DEVELOP into MAIN. Esperar aprobacion de los otros equipos (scrum ambassadors).

**TEAM -> DEVELOP**

- Hacer CHECKOUT a branch DEVELOP.

- Hacer PULL de cambios a branch DEVELOP y conciliar conflictos.

- Hacer CHECKOUT a branch TEAM.

- Mergear DEVELOP into TEAM y conciliar conflictos.

- Crear PR de TEAM into DEVELOP.

- Esperar aprobacion de 2 miembros de otros equipos.

![Estrategia Git](imgs/Estrategia_git.jpeg)

### Definición de listo<a name="DOD"></a>

La definición de listo (DOD) abarca los siguientes aspectos:

- **Arquitectura:**
    - Obedecer los principios SOLID.

- **Producto:**
    - El código debe cumplir los sigiuentes principios:
        - YAGNI
        - KISS
        - DRY

    - El código debe aprobar el linter de [Google.](https://google.github.io/styleguide/csharp-style.html)

- **Repositorio:**
    - Verificar la funcionalidad antes de fusionar una funcionalidad con el master.

- **Validación de historias con PO:**
    - Las historias deben de ser aceptadas por el equipo y el PO, antes de llevarse a un sprint.
    - Las historias de usuarios deben ser INVEST.

- **Intragrupal:**
    - Cualquier funcionalidad que se agregue no debe afectar a los demás equipos.
    - Comprobar las funcionalidades complementarias entre los grupos.

## Referencias bibliográficas<a name="Ref"></a> 

Atlassian. (n.d.-a). *Agile roadmaps: build, share, use, evolve*. 
&emsp;&emsp;&emsp;&nbsp;&nbsp;&nbsp;&nbsp;<https://www.atlassian.com/agile/product-management/roadmaps>

Atlassian. (n.d.-b). *Epics*. <https://www.atlassian.com/agile/project-management/epics>

Atlassian. (n.d.-c). *Git Feature Branch Workflow | Atlassian Git Tutorial*. 
&emsp;&emsp;&emsp;&nbsp;&nbsp;&nbsp;&nbsp;<https://www.atlassian.com/git/tutorials/comparing-workflows/feature-branch-workflow>

Atlassian. (n.d.-d). *Gitflow Workflow | Atlassian Git Tutorial*. 
&emsp;&emsp;&emsp;&nbsp;&nbsp;&nbsp;&nbsp;<https://www.atlassian.com/git/tutorials/comparing-workflows/gitflow-workflow>

Atlassian. (n.d.-e). *Product Backlog Grooming*. 
&emsp;&emsp;&emsp;&nbsp;&nbsp;&nbsp;&nbsp;<https://www.atlassian.com/agile/scrum/backlogs>

Atlassian. (n.d.-f). *Pull Requests | Atlassian Git Tutorial*. 
&emsp;&emsp;&emsp;&nbsp;&nbsp;&nbsp;&nbsp;<https://www.atlassian.com/git/tutorials/making-a-pull-request>

Atlassian. (n.d.-g). *User Stories | Examples and Template*. 
&emsp;&emsp;&emsp;&nbsp;&nbsp;&nbsp;&nbsp;<https://www.atlassian.com/agile/project-management/user-stories>

Atlassian. (n.d.-h). *What is Scrum?* <https://www.atlassian.com/agile/scrum>

Atlassian. (n.d.-i). *What is version control | Atlassian Git Tutorial*. 
&emsp;&emsp;&emsp;&nbsp;&nbsp;&nbsp;&nbsp;<https://www.atlassian.com/git/tutorials/what-is-version-control>

Cohn, M. (2005). *Agile Estimating and Planning* (1st ed.). Pearson.

Microsoft. (n.d.-a). *Microsoft SQL documentation* - SQL Server. Microsoft Docs. 
&emsp;&emsp;&emsp;&nbsp;&nbsp;&nbsp;&nbsp;<https://docs.microsoft.com/en-us/sql/?view=sql-server-ver15>

Microsoft. (n.d.-b). *Visual Studio documentation*. Microsoft Docs. 
&emsp;&emsp;&emsp;&nbsp;&nbsp;&nbsp;&nbsp;<https://docs.microsoft.com/en-us/visualstudio/windows/?view=vs-2019&preserve-view=true>

*Scrum Training Series: Free Scrum Master Training from Seattle*. (n.d.). Scrum Training 
&emsp;&emsp;&emsp;&nbsp;&nbsp;&nbsp;&nbsp;Series. <https://scrumtrainingseries.com/>

