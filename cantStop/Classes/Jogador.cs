﻿using System;
using System.Collections.Generic;
using CantStopServer;

namespace cantStop
{
    public class Jogador
    {
        public long id { get; set; }
        public string nome { get; set; }
        public string cor { get; set; }
        public string senha { get; set; }

        public void entrandoPartida(string dadosJogador, string nome)
        {
            dadosJogador = dadosJogador.Replace("\r\n", "");
            string[] itens = dadosJogador.Split(',');
            this.id = Convert.ToInt32(itens[0]);
            this.nome = nome;
            this.senha = itens[1];
            this.cor = itens[2];
        }

        public static List<Jogador> ListarJogadores(int idPartida)
        {
            string retorno = Jogo.ListarJogadores((int)idPartida);
            retorno = retorno.Replace("\r", "");
            string[] linhas = retorno.Split('\n');
            List<Jogador> listaJogadores = new List<Jogador>();

            for (int i = 0; i < linhas.Length - 1; i++)
            {
                Jogador jogador = new Jogador();
                string[] itens = linhas[i].Split(',');

                jogador.id = Convert.ToInt32(itens[0]);
                jogador.nome = itens[1];
                jogador.cor = itens[2];

                listaJogadores.Add(jogador);
            }

            return listaJogadores;
        }

        public List<int> RolarDados()
        {
            string retorno = Jogo.RolarDados((int)this.id, this.senha);
            retorno = retorno.Replace("\r\n", ";");
            retorno = retorno.Remove(retorno.Length - 1);
            string[] linhas = retorno.Split(';');

            List<int> dados = new List<int>();

            foreach (string linha in linhas)
            {
                dados.Add(linha[1] - '0');
            }

            return dados;
        }

        public void Parar()
        {
            Jogo.Parar((int)this.id, this.senha);
        }
    }
}