using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojinhaEcoomerce.DAL
{
    public sealed class Singleton
    {
        private static readonly Singleton instance = new Singleton();
        private readonly Contexto contexto;

        private Singleton() {
            contexto = new Contexto();
        }

        public static Singleton Instance
        {
            get {
                return instance;
            }
        }
        public Contexto Contexto {
            get {
                return contexto;
            }
        } 
    }
}