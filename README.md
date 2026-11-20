# Examen_RentzCar_RonaldValdez

## Nombre y matrícula
* **Nombre:** Ronald Valdez Francisco
* **Matrícula:** [2025-1402]

## Descripción
Aplicación de Windows Forms en C# para registrar alquileres de vehículos y calcular el total a pagar.

## Datos de entrada
* Cliente (`txtCliente`) y si es corporativo (`chkCorporativo`).
* Fecha de salida (`dtpSalida`).
* Vehículo (`txtVehiculo`), tarifa diaria (`txtTarifa`) y días del 1 al 30 (`nudDias`).
* Seguro: Básico o Completo (+RD$300 por día).
* Entrega: En sucursal o Domicilio (+RD$500).
* GPS: (+RD$100 por día).

## Proceso
1. Al cargar (`Load`), se inicializan los controles, el encabezado en fuente Consolas y los montos en cero.
2. Al agregar un vehículo, se calcula su tarifa diaria con seguro y GPS, se multiplica por los días, se suma al subtotal y se muestra en la lista.
3. Al calcular el total, se aplica 15% de descuento si es corporativo, se suma RD$500 si es a domicilio, se calcula el 18% de ITBIS sobre la base y se muestra el total.
4. Nuevo alquiler limpia todo y vuelve a empezar.
5. Salir pide confirmación antes de cerrar.

## Salida
* Lista de alquileres con columnas alineadas (`Días`, `Vehículo`, `Tarifa`, `Total`).
* Etiquetas de Subtotal, Descuento, Domicilio, ITBIS y Total a pagar en formato `RD$ 0.00`.

## Capturas de pantalla
<img width="911" height="545" alt="image" src="https://github.com/user-attachments/assets/a9b5a224-37e4-4c59-9200-36bc10ece0d9" />

