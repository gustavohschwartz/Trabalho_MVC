namespace MVC.Models.ModelView
{
    public class TarefasModelView

    {
        public string nomeTarefa { get; set; }

        public bool checkTarefa { get; set; }

        public TarefasModelView(string nome, bool check)
        {
            nomeTarefa = nome;
            checkTarefa = check;
        }
        public TarefasModelView()
        {

        }
    }
}