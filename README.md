
# Integración ChatGPT con SAP Business One usando .NET C#

🚀 Este proyecto permite la integración de la API de OpenAI (ChatGPT) con el ERP SAP Business One, utilizando .NET C# como tecnología principal.  
El objetivo es habilitar un **asistente inteligente** para consultas, generación de contenido, y soporte en procesos de negocio dentro del entorno de SAP B1.

---

## 🎯 Visión del Producto

✅ Desarrollar un conector seguro y escalable entre ChatGPT y SAP B1.  
✅ Ofrecer a los usuarios de SAP B1 una herramienta de asistencia conversacional para optimizar tareas operativas.  
✅ Permitir consultas de datos en SAP B1, generación de informes, y sugerencias inteligentes basadas en IA.  
✅ Construir una arquitectura extensible que permita nuevas funcionalidades en el futuro.

---

## 🧱 Arquitectura Tecnológica

- **Backend:** .NET 6/7 C#
- **API de IA:** OpenAI (ChatGPT, GPT-4/4.5/5)
- **ERP:** SAP Business One (SDK DI API / Service Layer)
- **Seguridad:** API Key y validaciones
- **Despliegue inicial:** On-Premise o en servidor Windows

📊 Ver diagrama: `DiagramaArquitectura.drawio` y `DiagramaArquitectura.png`

---

## ⚙️ Estructura del Proyecto

IntegracionChatGPT-SAPB1/
│
├── Controllers/
│ └── ChatGPTController.cs
│
├── Services/
│ ├── ChatGPTService.cs
│ └── SAPService.cs
│
├── Models/
│ ├── RequestModel.cs
│ └── ResponseModel.cs
│
├── Utils/
│ └── ConfigHelper.cs
│
├── DiagramaArquitectura.drawio
├── DiagramaArquitectura.png
├── IntegracionChatGPT-SAPB1.sln
├── README.md
└── appsettings.json
