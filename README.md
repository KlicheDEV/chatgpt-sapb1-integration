
# Integración ChatGPT con SAP Business One

Este proyecto demuestra cómo integrar ChatGPT con SAP Business One usando ASP.NET Core y el SDK de SAP.

## Componentes

- `Controllers/ChatController.cs`: API para recibir preguntas.
- `Services/ChatService.cs`: Lógica para procesar y consultar datos.
- `Utils/SapConnector.cs`: Utilitario para conectar a SAP.

## Uso

1. Configura tu API Key de OpenAI en `appsettings.json`.
2. Desarrolla tu lógica en `ChatService.cs`.
3. Expón el endpoint y prueba en Postman o Swagger.
