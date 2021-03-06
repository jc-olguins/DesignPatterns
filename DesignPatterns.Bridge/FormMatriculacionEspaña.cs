namespace DesignPatterns.Bridge
{
    public class FormularioMatriculacionEspaņa :
        FormularioMatriculacion
    {
        public FormularioMatriculacionEspaņa(IFormularioImpl
            implementacion) : base(implementacion) { }

        protected override bool ControlZona(string matricula)
        {
            return matricula.Length == 7;
        }
    }
}
