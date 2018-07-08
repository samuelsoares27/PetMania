using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetManiaServices.Repository
{
    public class ClienteRepository
    {
        //CREATE
        public Cliente Create(PetManiaDBEntities db, ClienteEntity c)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = c.Nome;
            cliente.CPF = c.CPF;
            cliente.Telefone = c.Telefone;
            cliente.Bairro = c.Bairro;
            cliente.Endereco = c.Endereco;
            cliente.Numero = c.Numero;
            cliente.Pet = c.Pet;
            cliente.Servico = c.Servico;
            cliente.Agendamento = c.Agendamento;
            db.Cliente.Add(cliente);
            return cliente;
        }

        //UPDATE
        public void Update(PetManiaDBEntities db, ClienteEntity c)
        {
            var cliente = (from cli in db.Cliente
                            where cli.IdCliente == c.IdCliente
                            select cli).Single();
            cliente.Nome = c.Nome;
            cliente.CPF = c.CPF;
            cliente.Telefone = c.Telefone;
            cliente.Bairro = c.Bairro;
            cliente.Endereco = c.Endereco;
            cliente.Numero = c.Numero;
            cliente.Pet = c.Pet;
            cliente.Servico = c.Servico;
            cliente.Agendamento = c.Agendamento;
        }

        //DELETE
        public void Delete(PetManiaDBEntities db, long id)
        {
            var cliente = (from cli in db.Cliente
                            where cli.IdCliente == id
                            select cli).Single();
            db.Cliente.Remove(cliente);
        }

        //DATATABLES
        #region
        //GET
        public ClienteEntity Get(PetManiaDBEntities db, long id)
        {
            return (from c in db.Cliente
                    where c.IdCliente == id
                    select new ClienteEntity
                    {
                        IdCliente = c.IdCliente,
                        Nome = c.Nome,
                        CPF = c.CPF,
                        Telefone = c.Telefone,
                        Bairro = c.Bairro,
                        Endereco = c.Endereco,
                        Numero = c.Numero,
                        Pet = c.Pet,
                        Servico = c.Servico,
                        Agendamento = c.Agendamento,
                    }).FirstOrDefault();
        }

        //GETTYPEAHEAD
        public List<ClienteEntity> GetTypeAhead(PetManiaDBEntities db, string busca)
        {
            var resultado = (from c in db.Cliente
                             where c.Nome.Contains("" + busca)
                             orderby c.Nome
                             select new ClienteEntity
                             {
                                 IdCliente = c.IdCliente,
                                 Nome = c.Nome,
                                 Pet = c.Pet,
                                 Servico = c.Servico,
                                 Agendamento = c.Agendamento,
                             }).Skip(0).Take(5).ToList();
            return resultado;
        }

        //GETCOUNT
        public List<ClienteEntity> GetCount(PetManiaDBEntities db)
        {
            return (from c in db.Cliente
                    orderby c.Nome
                    select new ClienteEntity
                    {
                        IdCliente = c.IdCliente,
                        Nome = c.Nome,
                        CPF = c.CPF,
                        Telefone = c.Telefone,
                        Bairro = c.Bairro,
                        Endereco = c.Endereco,
                        Numero = c.Numero,
                        Pet = c.Pet,
                        Servico = c.Servico,
                        Agendamento = c.Agendamento,
                    }).ToList();
        }

        //GETALL
        public List<ClienteEntity> GetAll(PetManiaDBEntities db, int start, int lenght)
        {
            return (from c in db.Cliente
                    orderby c.Nome
                    select new ClienteEntity
                    {
                        IdCliente = c.IdCliente,
                        Nome = c.Nome,
                        CPF = c.CPF,
                        Telefone = c.Telefone,
                        Bairro = c.Bairro,
                        Endereco = c.Endereco,
                        Numero = c.Numero,
                        Pet = c.Pet,
                        Servico = c.Servico,
                        Agendamento = c.Agendamento,
                    }).Skip(start).Take(lenght).ToList();
        }

        //GETSEARCH
        public List<ClienteEntity> GetSearch(PetManiaDBEntities db, string search)
        {
            return (from c in db.Cliente
                    where c.Nome.Contains("" + search)
                    orderby c.Nome
                    select new ClienteEntity
                    {
                        IdCliente = c.IdCliente,
                        Nome = c.Nome,
                        CPF = c.CPF,
                        Telefone = c.Telefone,
                        Bairro = c.Bairro,
                        Endereco = c.Endereco,
                        Numero = c.Numero,
                        Pet = c.Pet,
                        Servico = c.Servico,
                        Agendamento = c.Agendamento,
                    }).Skip(0).Take(10).ToList();
        }
        #endregion
    }
}