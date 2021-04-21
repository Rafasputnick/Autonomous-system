﻿using System;
using System.Collections.Generic;
using CantStopServer;

namespace cantStop
{
    public class Partida
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Status { get; set; }
        public string Senha { get; set; }
        public string Data { get; set; }
        public List<Jogador> jogadores { get; set; }

        public Partida()
        {
            this.jogadores = new List<Jogador>();
        }

        public void ListarJogadores()
        {
            string retorno = Jogo.ListarJogadores(this.Id);
            retorno = retorno.Replace("\r", "");
            string[] linhas = retorno.Split('\n');

            for (int i = 0; i < linhas.Length - 1; i++)
            {
                Jogador jogador = new Jogador();
                string[] itens = linhas[i].Split(',');

                jogador.id = Convert.ToInt32(itens[0]);
                jogador.nome = itens[1];
                jogador.cor = itens[2];

                this.jogadores.Add(jogador);
            }
        }

        public Jogador VerificarVez()
        {
            string retornoVez = Jogo.VerificarVez(this.Id);
            retornoVez = retornoVez.Replace("\r\n", "");
            string[] retornoVezProcessado = retornoVez.Split(',');

            foreach(Jogador jogador in this.jogadores)
            {
                if (jogador.id == int.Parse(retornoVezProcessado[1])) return jogador;
            }

            return null;
        }

        public String[] pegarHistorico()
        {
            string retornoHistorico = Jogo.ExibirHistorico(this.Id);
            retornoHistorico = retornoHistorico.Replace("\r", "");
            string[] historico = retornoHistorico.Split('\n');
            return historico;
        }
    }
}
