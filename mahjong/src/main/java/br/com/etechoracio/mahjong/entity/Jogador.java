package br.com.etechoracio.mahjong.entity;

import jakarta.persistence.*;
import lombok.Data;

@Entity
@Data
public class Jogador {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Integer id;
    private String nome;
    private int pontuacao;
}