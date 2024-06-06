﻿using PizzaMaui.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMaui.Data
{
    public class UsuarioData
    {
        private SQLiteAsyncConnection _conexaoDB;

        public UsuarioData(SQLiteAsyncConnection conexaoDB)
        {
            _conexaoDB = conexaoDB;
        }

        public Task<List<Usuario>> GetUsuariosAsync()
        {
            var lista = _conexaoDB.Table<Usuario>().ToListAsync();
            return lista;
        }

        public Task<Usuario> ObtemUsuario(string email, string senha)
        {
            var usuario = _conexaoDB
                .Table<Usuario>()
                .Where(x => x.Email == email && x.Senha == senha)
                .FirstOrDefaultAsync();
            return usuario;
        }


        public Task<Usuario> ObtemUsuario(Guid id)
        {
            var usuario = _conexaoDB.Table<Usuario>().Where(x => x.Id == id).FirstOrDefaultAsync();
            return usuario;
        }

        public async Task<int> SalvarUsuario(Usuario usuario)
        {
            var novoUsuario = await ObtemUsuario(usuario.Id);

            if (novoUsuario == null)
            {
                return await _conexaoDB.InsertAsync(usuario);

            }

            else
            {
                return await _conexaoDB.UpdateAsync(usuario);
            }
        }

        public async Task<int> DeletarUsuario(Usuario usuario)
        {
            return await _conexaoDB.DeleteAsync(usuario);
        }
    }
}
