package br.com.etechoracio.mahjong.controller;

import br.com.etechoracio.mahjong.entity.Partida;
import br.com.etechoracio.mahjong.service.PartidaService;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/partidas")
public class PartidaController {
    private final PartidaService partidaService;

    public PartidaController(PartidaService partidaService) {
        this.partidaService = partidaService;
    }

    @GetMapping
    public List<Partida> listarPartidas() {
        return partidaService.listarPartidas();
    }

    @PostMapping
    public Partida criarPartida(@RequestBody Partida partida) {
        return partidaService.salvarPartida(partida);
    }
}