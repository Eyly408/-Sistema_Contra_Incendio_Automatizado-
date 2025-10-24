# Sistema Contra Incendio Direccionable en C#

## Descripción General
Este proyecto consiste en la **simulación de un Sistema Contra Incendio (SCI)** desarrollado en **C#**, inspirado en el caso de la empresa *Grupo JJM SAC*.  
El sistema reproduce el comportamiento de un **panel central** que monitorea **sensores de humo, temperatura y estaciones manuales**, interconectados mediante un **lazo o loop direccionable**.
El objetivo principal es **demostrar el uso de algoritmos de control, funciones por valor y por referencia, y bibliotecas personalizadas** para simular el proceso de detección y respuesta ante una emergencia de incendio.

### Funcionalidades principales
- Lectura de datos de sensores simulados (humo, temperatura, estación manual).  
- Evaluación de condiciones de alarma mediante un algoritmo lógico.  
- Activación del panel central y de luces estroboscópicas cuando se detecta peligro.  
- Notificación simulada al sistema remoto.  
- Reinicio de sensores con paso por referencia (`ref`).  
- Estructura modular con bibliotecas separadas (`SensorLib`, `PanelLib`, `Anunciadores`).



