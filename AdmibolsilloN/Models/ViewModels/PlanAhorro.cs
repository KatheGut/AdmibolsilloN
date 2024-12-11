namespace AdmibolsilloN.Models.ViewModels
{
    public class PlanAhorro
    {
        public int IdPlan { get; set; }
        public string Objetivo { get; set; }
        public int Tiempo { get; set; }
        public int ValorPlanA { get; set; }
        public int? IdUsuario { get; set; }
        public string Fecha { get; set; }
        public Usuario Usuario { get; set; } // Relación con Usuario
    }
}
