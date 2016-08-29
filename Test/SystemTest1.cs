using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Imposto.Core.Domain;


namespace Test {
  [TestClass]
  public class SystemTest1 {
    [TestMethod]
    public void GenerateXml() {

      NotaFiscal nf = new NotaFiscal();
      Pedido pedido = new Pedido();
      PedidoItem item = new PedidoItem();
      NotaFiscalItem notaFiscalItem = new NotaFiscalItem();
      SalvaPedido order = new SalvaPedido();

      pedido.EstadoDestino = "SP";
      pedido.EstadoOrigem = "MG";
      pedido.NomeCliente = "Cliente Teste";

      item.NomeProduto = "Produto 1";
      item.CodigoProduto = "COD_100";
      item.ValorItemPedido = 200.00;
      item.Brinde = false;
      
      pedido.ItensDoPedido.Add(item);
      notaFiscalItem.Cfop = "6.003";
      notaFiscalItem.TipoIcms = "60";
      notaFiscalItem.AliquotaIcms = 0.17;
      notaFiscalItem.AliquotaIpi = 0.10;
      notaFiscalItem.BaseIcms = item.ValorItemPedido * 0.90;
      notaFiscalItem.BaseIpi = item.ValorItemPedido;
      notaFiscalItem.ValorIpi = notaFiscalItem.BaseIpi * notaFiscalItem.AliquotaIpi;
      notaFiscalItem.ValorIcms = notaFiscalItem.BaseIcms * notaFiscalItem.AliquotaIcms;

      nf.NumeroNotaFiscal = 99999;
      nf.Serie = new Random().Next(Int32.MaxValue);
      nf.NomeCliente = pedido.NomeCliente;
      nf.EstadoDestino = pedido.EstadoOrigem;
      nf.EstadoOrigem = pedido.EstadoDestino;

      if (nf.SerializeObject(nf))
        order.SaveItem(nf);

    }
  }
}
