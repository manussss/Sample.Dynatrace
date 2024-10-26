# Configurando a aplicação com Dynatrace

Essa configuração se baseia nas seguintes premissas:

- Você está utilizando uma máquina windows
- Possui o WSL instalado e configurado
- Possui o Docker instalado e configurado
- Possui uma conta no Dynatrace (incluso conta trial)

## Configurar Dynatrace

1. Acesse sua conta `dynatrace`
2. Acesse `deploy OneAgent`
3. Selecione `linux`
4. Crie um token baseado nas configurações abaixo:

![image](https://github.com/user-attachments/assets/2930b2a0-097e-498a-9f39-500924b6f30b)

5. Agora você terá um `token` e uma `url` para sua conta:

![image](https://github.com/user-attachments/assets/14c4190f-bd2c-4dc1-bae4-fa4e78be5eae)

O padrão da url é:
`https://<SEU-AMBIENTE>.live.dynatrace.com/api/v1/deployment/installer/agent/unix/default/latest?arch=<INSTALLER-TYPE>`

## Ajustar configuração da API

1. Altere o arquivo `appsettings` realizando as substituições do `token` e `url` obtidos no passo anterior
2. Altere o arquivo `docker-compose`, realizando as substituições do `token` e `url`:

![image](https://github.com/user-attachments/assets/21d3ed06-2673-42a7-9b21-92c37865fb39)

# Status do Agent

É possível visualizar o status do agent seguindo os passos:

1. Acesse `Deployment status`
2. Acesse `OneAgents`

Podemos verificar que ele está executando com sucesso e já está coletando métricas da nossa API:

![image](https://github.com/user-attachments/assets/6d38fa3d-f633-4939-8db2-fc3ca83e2bbe)

# Observabilidade

Com isso, podemos visualizar logs, métricas e outras ferramentas que o Dynatrace oferece.

## Logs

1. Acesse `Logs`

![image](https://github.com/user-attachments/assets/3ef526a8-a15f-464e-94ed-1f6365bd9f64)

## Data Explorer & Métricas

1. Acesse `Data Explorer`
2. É possível escolher dentre diversas métricas, onde os resultados são transformados para gerar insights:

![image](https://github.com/user-attachments/assets/f2b45969-4e9b-4a2d-91b1-dce45374177e)




