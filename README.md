# Museu Virtual de Machado de Assis

## 1. Descrição do projeto

O **Museu Virtual de Machado de Assis** é um projeto de Realidade Aumentada que visa proporcionar uma experiência interativa de exploração da vida e da obra de Machado de Assis, um dos maiores escritores da literatura brasileira.

Por meio da câmera e do reconhecimento de um QR Code ou alvo de imagem

## 2. Principais funcionalidades

- **Reconhecimento de imagem:** utilização do Vuforia para identificar o alvo visual e permitir a apresentação de conteúdo em Realidade Aumentada.
- **Interface em Realidade Aumentada:** exibição de elementos gráficos por meio de Canvas configurados em World Space, posicionados em relação ao alvo reconhecido.
- **Navegação interativa:** abertura de telas específicas para explorar os conteúdos disponíveis.
- **Conteúdo literário e visual:** apresentação de materiais relacionados a Machado de Assis e às suas obras.

## 3. Tecnologias, linguagens e bibliotecas

| Tecnologia | Utilização |
|---|---|
| Unity 6 | Desenvolvimento da aplicação, montagem da cena e renderização dos elementos em Realidade Aumentada. |
| C# | Implementação dos scripts de navegação entre Canvas e controle das interações. |
| Vuforia Engine | Reconhecimento e rastreamento do alvo de imagem utilizado na experiência de Realidade Aumentada. |
| Unity UI (uGUI) | Criação de menus, botões, painéis e interfaces gráficas. |
| EventSystem | Gerenciamento dos eventos de interação com os elementos da interface. |
| Input System | Gerenciamento das entradas do usuário, incluindo cliques do mouse durante os testes. |
| TextMeshPro | Exibição de textos com recursos avançados de formatação, quando utilizado nos elementos da interface. |

### Requisitos de software

- Unity 6, na versão utilizada para desenvolver o projeto
- Vuforia Engine, compatível com a versão da Unity instalada
- Visual Studio ou outro editor compatível com C#
- Pacote Input System
- Webcam para testes com a câmera do computador
- Dispositivo móvel compatível, caso a aplicação seja compilada para uso em celular
