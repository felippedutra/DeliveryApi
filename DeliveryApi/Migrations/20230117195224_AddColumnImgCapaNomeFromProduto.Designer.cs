﻿// <auto-generated />
using System;
using DeliveryApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DeliveryApi.Migrations
{
    [DbContext(typeof(WebAppDbContext))]
    [Migration("20230117195224_AddColumnImgCapaNomeFromProduto")]
    partial class AddColumnImgCapaNomeFromProduto
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DeliveryApi.Models.CategoriaProdutoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit")
                        .HasColumnName("ativo");

                    b.Property<DateTime>("DtAtualizacao")
                        .HasColumnType("datetime2")
                        .HasColumnName("dt_atualizacao");

                    b.Property<DateTime>("DtCadastro")
                        .HasColumnType("datetime2")
                        .HasColumnName("dt_cadastro");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("nome");

                    b.HasKey("Id");

                    b.ToTable("categorias_produtos");
                });

            modelBuilder.Entity("DeliveryApi.Models.ClienteModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit")
                        .HasColumnName("ativo");

                    b.Property<DateTime>("DtAtualizacao")
                        .HasColumnType("datetime2")
                        .HasColumnName("dt_atualizacao");

                    b.Property<DateTime>("DtCadastro")
                        .HasColumnType("datetime2")
                        .HasColumnName("dt_cadastro");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("email");

                    b.Property<int>("EmpresaId")
                        .HasColumnType("int")
                        .HasColumnName("empresa_id");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("nome");

                    b.Property<string>("Senha")
                        .HasMaxLength(22)
                        .HasColumnType("nvarchar(22)")
                        .HasColumnName("senha");

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)")
                        .HasColumnName("sexo");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)")
                        .HasColumnName("telefone");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.ToTable("clientes");
                });

            modelBuilder.Entity("DeliveryApi.Models.EmpresaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit")
                        .HasColumnName("ativo");

                    b.Property<string>("Bairro")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("bairro");

                    b.Property<string>("Cep")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("cep");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("cidade");

                    b.Property<string>("Cnpj")
                        .HasMaxLength(18)
                        .HasColumnType("nvarchar(18)")
                        .HasColumnName("cnpj");

                    b.Property<string>("Complemento")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("complemento");

                    b.Property<DateTime>("DtAtualizacao")
                        .HasColumnType("datetime2")
                        .HasColumnName("dt_atualizacao");

                    b.Property<DateTime>("DtCadastro")
                        .HasColumnType("datetime2")
                        .HasColumnName("dt_cadastro");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("email");

                    b.Property<string>("Lote")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("lote");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("nome");

                    b.Property<string>("Numero")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("numero");

                    b.Property<string>("Quadra")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("quadra");

                    b.Property<string>("Rua")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("rua");

                    b.Property<string>("Telefone1")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)")
                        .HasColumnName("telefone1");

                    b.Property<string>("Telefone2")
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)")
                        .HasColumnName("telefone2");

                    b.Property<string>("Uf")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)")
                        .HasColumnName("uf");

                    b.HasKey("Id");

                    b.ToTable("empresas");
                });

            modelBuilder.Entity("DeliveryApi.Models.EnderecoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit")
                        .HasColumnName("ativo");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("bairro");

                    b.Property<string>("Cep")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("cep");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("cidade");

                    b.Property<int>("ClienteId")
                        .HasColumnType("int")
                        .HasColumnName("cliente_id");

                    b.Property<string>("Complemento")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("complemento");

                    b.Property<DateTime>("DtAtualizacao")
                        .HasColumnType("datetime2")
                        .HasColumnName("dt_atualizacao");

                    b.Property<DateTime>("DtCadastro")
                        .HasColumnType("datetime2")
                        .HasColumnName("dt_cadastro");

                    b.Property<string>("Lote")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("lote");

                    b.Property<string>("Numero")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("numero");

                    b.Property<string>("Quadra")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("quadra");

                    b.Property<string>("Rua")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("rua");

                    b.Property<int>("TipoEnderecoId")
                        .HasColumnType("int")
                        .HasColumnName("tipo_endereco_id");

                    b.Property<string>("Uf")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)")
                        .HasColumnName("uf");

                    b.HasKey("Id");

                    b.HasIndex("TipoEnderecoId");

                    b.ToTable("enderecos");
                });

            modelBuilder.Entity("DeliveryApi.Models.ErroModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit")
                        .HasColumnName("ativo");

                    b.Property<string>("Descricao")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("descricao");

                    b.Property<string>("DescricaoCompleta")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("descricao_completa");

                    b.Property<DateTime>("DtAtualizacao")
                        .HasColumnType("datetime2")
                        .HasColumnName("dt_atualizacao");

                    b.Property<DateTime>("DtCadastro")
                        .HasColumnType("datetime2")
                        .HasColumnName("dt_cadastro");

                    b.Property<string>("NomeAplicacao")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nome_aplicacao");

                    b.Property<string>("NomeFuncao")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nome_funcao");

                    b.Property<string>("ParametroEntrada")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("parametro_entrada");

                    b.Property<int>("RegistroCorrenteId")
                        .HasColumnType("int")
                        .HasColumnName("registro_corrente_id");

                    b.Property<int>("StatusCode")
                        .HasColumnType("int")
                        .HasColumnName("status_code");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("url");

                    b.HasKey("Id");

                    b.ToTable("erros");
                });

            modelBuilder.Entity("DeliveryApi.Models.PedidoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit")
                        .HasColumnName("ativo");

                    b.Property<int>("ClienteId")
                        .HasColumnType("int")
                        .HasColumnName("cliente_id");

                    b.Property<DateTime>("DtAtualizacao")
                        .HasColumnType("datetime2")
                        .HasColumnName("dt_atualizacao");

                    b.Property<DateTime>("DtCadastro")
                        .HasColumnType("datetime2")
                        .HasColumnName("dt_cadastro");

                    b.Property<int>("EmpresaId")
                        .HasColumnType("int")
                        .HasColumnName("empresa_id");

                    b.Property<int>("EnderecoId")
                        .HasColumnType("int")
                        .HasColumnName("endereco_id");

                    b.Property<int>("SituacaoPedidoId")
                        .HasColumnType("int")
                        .HasColumnName("situacao_pedido_id");

                    b.Property<int>("TipoPedidoId")
                        .HasColumnType("int")
                        .HasColumnName("tipo_pedido_id");

                    b.Property<double>("ValorTotal")
                        .HasColumnType("float")
                        .HasColumnName("valor_total");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("EmpresaId");

                    b.HasIndex("EnderecoId");

                    b.HasIndex("SituacaoPedidoId");

                    b.HasIndex("TipoPedidoId");

                    b.ToTable("pedidos");
                });

            modelBuilder.Entity("DeliveryApi.Models.PedidoProdutoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Observacao")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("observacao");

                    b.Property<int>("PedidoId")
                        .HasColumnType("int")
                        .HasColumnName("pedido_id");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int")
                        .HasColumnName("produto_id");

                    b.Property<int>("Qtd")
                        .HasColumnType("int")
                        .HasColumnName("qtd");

                    b.HasKey("Id");

                    b.HasIndex("PedidoId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("pedidos_produtos");
                });

            modelBuilder.Entity("DeliveryApi.Models.ProdutoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit")
                        .HasColumnName("ativo");

                    b.Property<int>("CategoriaProdutoId")
                        .HasColumnType("int")
                        .HasColumnName("categoria_produto_id");

                    b.Property<string>("Descricao")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("descricao");

                    b.Property<DateTime>("DtAtualizacao")
                        .HasColumnType("datetime2")
                        .HasColumnName("dt_atualizacao");

                    b.Property<DateTime>("DtCadastro")
                        .HasColumnType("datetime2")
                        .HasColumnName("dt_cadastro");

                    b.Property<int>("EmpresaId")
                        .HasColumnType("int")
                        .HasColumnName("empresa_id");

                    b.Property<string>("ImgCapaNome")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("img_capa_nome");

                    b.Property<string>("ImgCapaUrl")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("img_capa_url");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("nome");

                    b.Property<int>("Qtd")
                        .HasColumnType("int")
                        .HasColumnName("qtd");

                    b.Property<int>("TipoMedidaId")
                        .HasColumnType("int")
                        .HasColumnName("tipo_medida_id");

                    b.Property<float>("Valor")
                        .HasColumnType("real")
                        .HasColumnName("valor");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaProdutoId");

                    b.HasIndex("EmpresaId");

                    b.HasIndex("TipoMedidaId");

                    b.ToTable("produtos");
                });

            modelBuilder.Entity("DeliveryApi.Models.SituacaoPedidoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit")
                        .HasColumnName("ativo");

                    b.Property<DateTime>("DtAtualizacao")
                        .HasColumnType("datetime2")
                        .HasColumnName("dt_atualizacao");

                    b.Property<DateTime>("DtCadastro")
                        .HasColumnType("datetime2")
                        .HasColumnName("dt_cadastro");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("nome");

                    b.HasKey("Id");

                    b.ToTable("situacoes_pedidos");
                });

            modelBuilder.Entity("DeliveryApi.Models.TipoEnderecoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit")
                        .HasColumnName("ativo");

                    b.Property<DateTime>("DtAtualizacao")
                        .HasColumnType("datetime2")
                        .HasColumnName("dt_atualizacao");

                    b.Property<DateTime>("DtCadastro")
                        .HasColumnType("datetime2")
                        .HasColumnName("dt_cadastro");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("nome");

                    b.HasKey("Id");

                    b.ToTable("tipos_enderecos");
                });

            modelBuilder.Entity("DeliveryApi.Models.TipoMedidaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit")
                        .HasColumnName("ativo");

                    b.Property<DateTime>("DtAtualizacao")
                        .HasColumnType("datetime2")
                        .HasColumnName("dt_atualizacao");

                    b.Property<DateTime>("DtCadastro")
                        .HasColumnType("datetime2")
                        .HasColumnName("dt_cadastro");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("nome");

                    b.HasKey("Id");

                    b.ToTable("tipos_medidas");
                });

            modelBuilder.Entity("DeliveryApi.Models.TipoPedidoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit")
                        .HasColumnName("ativo");

                    b.Property<DateTime>("DtAtualizacao")
                        .HasColumnType("datetime2")
                        .HasColumnName("dt_atualizacao");

                    b.Property<DateTime>("DtCadastro")
                        .HasColumnType("datetime2")
                        .HasColumnName("dt_cadastro");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("nome");

                    b.HasKey("Id");

                    b.ToTable("tipos_pedidos");
                });

            modelBuilder.Entity("DeliveryApi.Models.TipoUsuarioModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit")
                        .HasColumnName("ativo");

                    b.Property<DateTime>("DtAtualizacao")
                        .HasColumnType("datetime2")
                        .HasColumnName("dt_atualizacao");

                    b.Property<DateTime>("DtCadastro")
                        .HasColumnType("datetime2")
                        .HasColumnName("dt_cadastro");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("nome");

                    b.HasKey("Id");

                    b.ToTable("tipos_usuarios");
                });

            modelBuilder.Entity("DeliveryApi.Models.UsuarioModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit")
                        .HasColumnName("ativo");

                    b.Property<DateTime>("DtAtualizacao")
                        .HasColumnType("datetime2")
                        .HasColumnName("dt_atualizacao");

                    b.Property<DateTime>("DtCadastro")
                        .HasColumnType("datetime2")
                        .HasColumnName("dt_cadastro");

                    b.Property<DateTime>("DtUltimoAcesso")
                        .HasColumnType("datetime2")
                        .HasColumnName("dt_ultimo_acesso");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("email");

                    b.Property<int>("EmpresaId")
                        .HasColumnType("int")
                        .HasColumnName("empresa_id");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("nome");

                    b.Property<string>("Senha")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("senha");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)")
                        .HasColumnName("telefone");

                    b.Property<int>("TipoUsuarioId")
                        .HasColumnType("int")
                        .HasColumnName("tipo_usuario_id");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.HasIndex("TipoUsuarioId");

                    b.ToTable("usuarios");
                });

            modelBuilder.Entity("DeliveryApi.Models.ClienteModel", b =>
                {
                    b.HasOne("DeliveryApi.Models.EmpresaModel", "Empresa")
                        .WithMany()
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Empresa");
                });

            modelBuilder.Entity("DeliveryApi.Models.EnderecoModel", b =>
                {
                    b.HasOne("DeliveryApi.Models.TipoEnderecoModel", "TipoEndereco")
                        .WithMany()
                        .HasForeignKey("TipoEnderecoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("TipoEndereco");
                });

            modelBuilder.Entity("DeliveryApi.Models.PedidoModel", b =>
                {
                    b.HasOne("DeliveryApi.Models.ClienteModel", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DeliveryApi.Models.EmpresaModel", "Empresa")
                        .WithMany()
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DeliveryApi.Models.EnderecoModel", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DeliveryApi.Models.SituacaoPedidoModel", "SituacaoPedido")
                        .WithMany()
                        .HasForeignKey("SituacaoPedidoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DeliveryApi.Models.TipoPedidoModel", "TipoPedido")
                        .WithMany()
                        .HasForeignKey("TipoPedidoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Empresa");

                    b.Navigation("Endereco");

                    b.Navigation("SituacaoPedido");

                    b.Navigation("TipoPedido");
                });

            modelBuilder.Entity("DeliveryApi.Models.PedidoProdutoModel", b =>
                {
                    b.HasOne("DeliveryApi.Models.PedidoModel", "Pedido")
                        .WithMany("PedidoProdutos")
                        .HasForeignKey("PedidoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DeliveryApi.Models.ProdutoModel", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Pedido");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("DeliveryApi.Models.ProdutoModel", b =>
                {
                    b.HasOne("DeliveryApi.Models.CategoriaProdutoModel", "CategoriaProduto")
                        .WithMany()
                        .HasForeignKey("CategoriaProdutoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DeliveryApi.Models.EmpresaModel", "Empresa")
                        .WithMany()
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DeliveryApi.Models.TipoMedidaModel", "TipoMedida")
                        .WithMany()
                        .HasForeignKey("TipoMedidaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("CategoriaProduto");

                    b.Navigation("Empresa");

                    b.Navigation("TipoMedida");
                });

            modelBuilder.Entity("DeliveryApi.Models.UsuarioModel", b =>
                {
                    b.HasOne("DeliveryApi.Models.EmpresaModel", "Empresa")
                        .WithMany()
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DeliveryApi.Models.TipoUsuarioModel", "TipoUsuario")
                        .WithMany()
                        .HasForeignKey("TipoUsuarioId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Empresa");

                    b.Navigation("TipoUsuario");
                });

            modelBuilder.Entity("DeliveryApi.Models.PedidoModel", b =>
                {
                    b.Navigation("PedidoProdutos");
                });
#pragma warning restore 612, 618
        }
    }
}
