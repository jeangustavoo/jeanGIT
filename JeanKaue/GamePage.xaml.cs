namespace JeanKaue;

public partial class GamePage : ContentPage
{
    
  List<HistoryStep> historia = new List<HistoryStep>();
  HistoryStep HistoryStepAtual;

  public GamePage()
	{
		InitializeComponent();

    historia.Add(new HistoryStep()
    {
 Id = 0,
      Texto = "Salve jogador, parece que você quer ter uma carreira brilhante pela frente, então vamos começar?"
      TemResposta=false
    });
    historia.Add(new HistoryStep()
    {
      Id = 1,
      Texto = "Em qual time você desejar começar sua carreira?",
      TemResposta=true,
      TextoDaResposta01="Bahia",
      TextoDaResposta02="Santos",
      TextoDaResposta03="Vasco",
      IdLevelResposta01=2,
      IdLevelResposta02=998,
      IdLevelResposta03=999,
    });
     historia.Add(new HistoryStep()
    {
      Id = 2,
      Texto = "Você entrou em um time em ascenção, será que tornará um grande idolo?",
      TemResposta=false,
    });
    historia.Add(new HistoryStep()
    {
      Id = 3,
      Texto = "Você recebeu uma proposta de um time asiático, com um enorme salário, você deseja fazer essa troca?",
      TemResposta=true,
      TextoDaResposta01="Não, desejo continuar no Bahia",
      TextoDaResposta02="Sim, desejo receber um salário melhor!",
      IdLevelResposta01=4,
      IdLevelResposta02=998,
    });
    historia.Add(new HistoryStep()
    {
      Id = 4,
      Texto = "Você fez a escolha certa, virou um dos maiores idolos no Bahia, ganhou varios titulos importantes para o clube. Parabens jogador!",
      aposentadoriajogador=false,
    });
     historia.Add(new HistoryStep()
    {
      Id = 998,
      Texto = "Seu time caiu!",
      TemResposta=false,
    });
     historia.Add(new HistoryStep()
    {
      Id = 999,
      Texto = "Seu time faliu e sua carreira acabou!",
      TemResposta=false,
    });
     historia.Add(new HistoryStep()
    {
      Id = 1000,
      Texto = "APOSENTOU!!!",
      TemResposta=false,
    });
//void QuandoClicarContinuar(object sender, EventArgs args)
  //{
   // var proximoId = HistoryStepAtual.Id + 1;
    //TrocaHistoryStepAtual(proximoId);
  //}
// private void QuandoClicarVoltar(object sender, EventArgs args)
 // {
    //LinhaAberta.IsVisible = false;
  //}
}