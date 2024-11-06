package br.com.etechoracio.mahjong.service;

import br.com.etechoracio.mahjong.entity.Partida;
import br.com.etechoracio.mahjong.repository.PartidaRepository;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class PartidaService {
    private final PartidaRepository partidaRepository;

    public PartidaService(PartidaRepository partidaRepository) {
        this.partidaRepository = partidaRepository;
    }

    public List<Partida> listarPartidas() {
        return partidaRepository.findAll();
    }

    public Partida salvarPartida(Partida partida) {
        return partidaRepository.save(partida);
    }
}