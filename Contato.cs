using System.Collections.Generic;

namespace agenda
{
    public class Contato
    {
        private List<ItemContato> ItemContato;
    
        public Contato(){
            ItemContato = new List<ItemContato>();
        }

        public void adicionaContato(ItemContato item){
            ItemContato.Add(item);
        }
        public int TotalContatos(){
            int total = 0;
            foreach( var item in ItemContato){
                total ++;
            }
            return total;
        }
    }
}