### Para rodar

**É necessário ter um projeto Firebase configurado na plataforma do Google: https://firebase.google.com**

Defina a variável de ambiente para a sessão shell atual: `$env:GOOGLE_APPLICATION_CREDENTIALS="Camino do arquivo json da chave provada do firebase"`
 - Esse comando vai manter a chave enquanto o shell de comando estiver aberto. Uma vez fechado, a variável de ambiente se perde.
 - Está chave é secreta da sua aplicação firebase, cuidado para não compartilhá-la indevidamente.
 - Para mais informações, consulte: https://firebase.google.com/docs/cloud-messaging/auth-server?hl=pt-br

**Levantando o servidor:** `dotnet run`
**URL da API:** http://localhost:5000

### Criando notificações com a API:

Três dados são necessários:
- Título: Título da notificação
- Mensagem: Menssagem da notificação
- Token: Toquem no dispositivo que deve receber a notificação (Mais detalhes: https://firebase.google.com/docs/cloud-messaging/android/client?hl=pt-br#sample-register) 
