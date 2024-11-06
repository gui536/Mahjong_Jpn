package br.com.etechoracio.mahjong.entity;

import jakarta.persistence.*;
import lombok.Data;

@Entity
@Data
public class Partida {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Integer id;

    @ManyToOne
    @JoinColumn(name = "jogador1Id")
    private Jogador jogador1;

    @ManyToOne
    @JoinColumn(name = "jogador2Id")
    private Jogador jogador2;

    @ManyToOne
    @JoinColumn(name = "vencedorId")
    private Jogador vencedor;
}