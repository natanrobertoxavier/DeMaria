--
-- PostgreSQL database dump
--

-- Dumped from database version 16.3
-- Dumped by pg_dump version 16.3

-- Started on 2024-05-31 11:06:43

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

--
-- TOC entry 4 (class 2615 OID 2200)
-- Name: public; Type: SCHEMA; Schema: -; Owner: pg_database_owner
--

CREATE SCHEMA public;


ALTER SCHEMA public OWNER TO pg_database_owner;

--
-- TOC entry 4873 (class 0 OID 0)
-- Dependencies: 4
-- Name: SCHEMA public; Type: COMMENT; Schema: -; Owner: pg_database_owner
--

COMMENT ON SCHEMA public IS 'standard public schema';


SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- TOC entry 215 (class 1259 OID 16399)
-- Name: clientes; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.clientes (
    id integer NOT NULL,
    nome text NOT NULL,
    endereco text NOT NULL,
    telefone text,
    email text,
    cpf text
);


ALTER TABLE public.clientes OWNER TO postgres;

--
-- TOC entry 216 (class 1259 OID 16406)
-- Name: clientes_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.clientes ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.clientes_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 222 (class 1259 OID 16471)
-- Name: itensdavenda; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.itensdavenda (
    id integer NOT NULL,
    codigodebarras text NOT NULL,
    quantidade numeric(10,2) NOT NULL,
    valorunitario numeric(10,2) NOT NULL,
    valortotal numeric(10,2) NOT NULL,
    codigodavenda text NOT NULL
);


ALTER TABLE public.itensdavenda OWNER TO postgres;

--
-- TOC entry 221 (class 1259 OID 16470)
-- Name: itensdavenda_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.itensdavenda ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.itensdavenda_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 218 (class 1259 OID 16428)
-- Name: produtos; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.produtos (
    id integer NOT NULL,
    nome text NOT NULL,
    descricao text,
    preco numeric(10,2) NOT NULL,
    estoqueatual numeric(10,2),
    codigodebarras text NOT NULL
);


ALTER TABLE public.produtos OWNER TO postgres;

--
-- TOC entry 217 (class 1259 OID 16427)
-- Name: produtos_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.produtos ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.produtos_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 220 (class 1259 OID 16436)
-- Name: vendas; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.vendas (
    id integer NOT NULL,
    clienteid integer NOT NULL,
    quantidade numeric(10,3) NOT NULL,
    valortotal numeric(10,2) NOT NULL,
    datacadastro timestamp with time zone NOT NULL,
    codigodavenda text NOT NULL
);


ALTER TABLE public.vendas OWNER TO postgres;

--
-- TOC entry 219 (class 1259 OID 16435)
-- Name: vendas_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.vendas ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.vendas_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 4860 (class 0 OID 16399)
-- Dependencies: 215
-- Data for Name: clientes; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.clientes (id, nome, endereco, telefone, email, cpf) FROM stdin;
26	PAULO CASTRO	RUA S, 4041	(19) 9 9012-3456	PAULO.CASTRO@EXAMPLE.COM	890.345.671-98
27	SANDRA LIMA	AV. T, 4243	(20) 9 0123-4567	SANDRA.LIMA@EXAMPLE.COM	567.908.321-84
28	DIEGO FERNANDES	RUA U, 4445	(21) 9 1234-5678	DIEGO.FERNANDES@EXAMPLE.COM	234.987.650-71
29	CAMILA PEREIRA	AV. V, 4647	(22) 9 2345-6789	CAMILA.PEREIRA@EXAMPLE.COM	789.230.456-12
9	MARIA OLIVEIRA	AV. B, 456	(22) 9 2345-6789	MARIA.OLIVEIRA@EXAMPLE.COM	175.294.683-27
10	PEDRO SANTOS	RUA C, 789	(33) 9 3456-7890	PEDRO.SANTOS@EXAMPLE.COM	408.932.576-85
11	ANA SOUZA	AV. D, 1011	(44) 9 4567-8901	ANA.SOUZA@EXAMPLE.COM	236.719.845-62
12	CARLOS PEREIRA	RUA E, 1213	(55) 9 5678-9012	CARLOS.PEREIRA@EXAMPLE.COM	159.743.280-69
13	JULIANA LIMA	AV. F, 1415	(66) 9 6789-0123	JULIANA.LIMA@EXAMPLE.COM	632.894.715-38
14	FERNANDO COSTA	RUA G, 1617	(77) 9 7890-1234	FERNANDO.COSTA@EXAMPLE.COM	487.106.359-24
15	AMANDA CASTRO	AV. H, 1819	(88) 9 8901-2345	AMANDA.CASTRO@EXAMPLE.COM	810.365.492-17
16	RAFAEL ALMEIDA	RUA I, 2021	(99) 9 9012-3456	RAFAEL.ALMEIDA@EXAMPLE.COM	297.504.186-23
17	PATRÍCIA FERNANDES	AV. J, 2223	(10) 9 0123-4567	PATRICIA.FERNANDES@EXAMPLE.COM	549.617.320-45
18	GUSTAVO MARTINS	RUA K, 2425	(11) 9 1234-5678	GUSTAVO.MARTINS@EXAMPLE.COM	731.985.624-87
19	VANESSA OLIVEIRA	AV. L, 2627	(12) 9 2345-6789	VANESSA.OLIVEIRA@EXAMPLE.COM	874.206.931-57
20	ROBERTO SILVA	RUA M, 2829	(13) 9 3456-7890	ROBERTO.SILVA@EXAMPLE.COM	650.382.971-04
21	CRISTINA NUNES	AV. N, 3031	(14) 9 4567-8901	CRISTINA.NUNES@EXAMPLE.COM	319.578.402-65
22	LUCAS COSTA	RUA O, 3233	(15) 9 5678-9012	LUCAS.COSTA@EXAMPLE.COM	942.716.530-89
23	DANIELA RODRIGUES	AV. P, 3435	(16) 9 6789-0123	DANIELA.RODRIGUES@EXAMPLE.COM	487.930.621-85
24	JOSÉ SANTOS	RUA Q, 3637	(17) 9 7890-1234	JOSE.SANTOS@EXAMPLE.COM	765.831.402-59
25	MARIANA ALMEIDA	AV. R, 3839	(18) 9 8901-2345	MARIANA.ALMEIDA@EXAMPLE.COM	123.456.789-09
30	FÁBIO OLIVEIRA	RUA W, 4849	(23) 9 3456-7890	FABIO.OLIVEIRA@EXAMPLE.COM	456.789.345-02
31	TATIANE SOUZA	AV. X, 5051	(24) 9 4567-8901	TATIANE.SOUZA@EXAMPLE.COM	123.456.789-03
32	LEANDRO COSTA	RUA Y, 5253	(25) 9 5678-9012	LEANDRO.COSTA@EXAMPLE.COM	890.123.456-04
8	JOÃO DA SILVA	RUA A, 123	(11) 9 1234-5678	JOAO.SILVA@EXAMPLE.COM	672.945.831-94
1	NATAN ROBERTO SANCHES PEDRINI XAVIER	RUA CLOVIS DE OLIVIERA, 790	(11) 9 7700-0061	NATANROBERTO182@GMAIL.COM	390.130.288-37
37	MARIANE SILVA	RUA DAS COUVES, 74	(11) 1 1111-1111	MARYANE@MARYANE.COM	999.999.999-99
\.


--
-- TOC entry 4867 (class 0 OID 16471)
-- Dependencies: 222
-- Data for Name: itensdavenda; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.itensdavenda (id, codigodebarras, quantidade, valorunitario, valortotal, codigodavenda) FROM stdin;
6	80394101	10.00	54.79	547.90	60PXAO1VE
7	572483192054	1.00	11.07	11.07	60PXAO1VE
8	80394101	150.00	54.79	8218.50	RIXUWKXV7
9	12948567	1.00	36.74	36.74	NFAM5Y446
10	109374605	12.00	95.67	1148.04	NFAM5Y446
11	102938475	1.00	94.75	94.75	H3EF99EZG
12	64031928	1.00	59.28	59.28	H3EF99EZG
13	64031928	1.00	59.28	59.28	H3EF99EZG
14	64031928	1.00	59.28	59.28	H3EF99EZG
15	58603247	1.00	82.39	82.39	G6O3SNL8T
16	73490852	1.00	85.40	85.40	P1V982A7H
\.


--
-- TOC entry 4863 (class 0 OID 16428)
-- Dependencies: 218
-- Data for Name: produtos; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.produtos (id, nome, descricao, preco, estoqueatual, codigodebarras) FROM stdin;
3	Produto 1	Descricao do Produto 1	54.79	654.00	80394101
4	Produto 2	Descricao do Produto 2	89.13	742.00	893574094028
5	Produto 3	Descricao do Produto 3	76.38	35.00	652704
6	Produto 4	Descricao do Produto 4	51.44	525.00	8392045730
7	Produto 5	Descricao do Produto 5	83.45	62.00	406538213
8	Produto 6	Descricao do Produto 6	95.67	783.00	109374605
10	Produto 8	Descricao do Produto 8	26.15	361.00	380594726
11	Produto 9	Descricao do Produto 9	59.24	821.00	90257184
12	Produto 10	Descricao do Produto 10	22.47	191.00	635849210
13	Produto 11	Descricao do Produto 11	17.88	75.00	503847120
14	Produto 12	Descricao do Produto 12	87.91	876.00	45678930
15	Produto 13	Descricao do Produto 13	92.12	274.00	7356024189
16	Produto 14	Descricao do Produto 14	24.73	90.00	54739210845
17	Produto 15	Descricao do Produto 15	63.05	652.00	98374162
18	Produto 16	Descricao do Produto 16	78.24	43.00	384659172
19	Produto 17	Descricao do Produto 17	16.92	785.00	726149308
20	Produto 18	Descricao do Produto 18	46.31	670.00	8345062719
21	Produto 19	Descricao do Produto 19	59.28	57.00	64031928
22	Produto 20	Descricao do Produto 20	49.60	924.00	309576841
23	Produto 21	Descricao do Produto 21	96.73	340.00	724618309
24	Produto 22	Descricao do Produto 22	18.34	675.00	803549172
25	Produto 23	Descricao do Produto 23	10.27	73.00	675804321
26	Produto 24	Descricao do Produto 24	23.91	58.00	1926745803
27	Produto 25	Descricao do Produto 25	70.16	164.00	80637459
28	Produto 26	Descricao do Produto 26	85.40	26.00	73490852
29	Produto 27	Descricao do Produto 27	37.60	718.00	4085731962
30	Produto 28	Descricao do Produto 28	21.97	574.00	81920347
31	Produto 29	Descricao do Produto 29	94.75	451.00	102938475
32	Produto 30	Descricao do Produto 30	47.62	183.00	94057623
33	Produto 31	Descricao do Produto 31	30.91	297.00	7583401296
34	Produto 32	Descricao do Produto 32	52.84	849.00	620438519
35	Produto 33	Descricao do Produto 33	79.45	215.00	572381904
36	Produto 34	Descricao do Produto 34	64.23	417.00	3745928610
37	Produto 35	Descricao do Produto 35	27.96	933.00	68045217
38	Produto 36	Descricao do Produto 36	43.75	189.00	12938574
39	Produto 37	Descricao do Produto 37	82.39	572.00	58603247
40	Produto 38	Descricao do Produto 38	90.14	304.00	48735912
41	Produto 39	Descricao do Produto 39	68.92	120.00	2049385761
42	Produto 40	Descricao do Produto 40	29.65	73.00	84019263
43	Produto 41	Descricao do Produto 41	15.83	907.00	6158274903
44	Produto 42	Descricao do Produto 42	19.27	256.00	738291045
45	Produto 43	Descricao do Produto 43	36.74	743.00	12948567
46	Produto 44	Descricao do Produto 44	58.29	82.00	385716429
47	Produto 45	Descricao do Produto 45	55.67	419.00	68341290
48	Produto 46	Descricao do Produto 46	81.30	651.00	93486752
49	Produto 47	Descricao do Produto 47	12.50	344.00	5071932846
9	AAAAAAA PRODUTO 7	ALTERACAO DE TESTE	11.07	186.00	572483192054
\.


--
-- TOC entry 4865 (class 0 OID 16436)
-- Dependencies: 220
-- Data for Name: vendas; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.vendas (id, clienteid, quantidade, valortotal, datacadastro, codigodavenda) FROM stdin;
2	1	11.000	558.97	2024-05-30 00:00:00+00	60PXAO1VE
3	1	150.000	8218.50	2024-05-31 08:33:32.935296+00	RIXUWKXV7
4	29	13.000	1184.78	2024-05-31 08:37:24.386414+00	NFAM5Y446
5	24	4.000	272.59	2024-05-31 09:17:45.652268+00	H3EF99EZG
6	29	1.000	82.39	2024-05-31 09:52:30.757047+00	G6O3SNL8T
7	37	1.000	85.40	2024-05-31 09:56:34.566737+00	P1V982A7H
\.


--
-- TOC entry 4874 (class 0 OID 0)
-- Dependencies: 216
-- Name: clientes_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.clientes_id_seq', 39, true);


--
-- TOC entry 4875 (class 0 OID 0)
-- Dependencies: 221
-- Name: itensdavenda_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.itensdavenda_id_seq', 16, true);


--
-- TOC entry 4876 (class 0 OID 0)
-- Dependencies: 217
-- Name: produtos_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.produtos_id_seq', 50, true);


--
-- TOC entry 4877 (class 0 OID 0)
-- Dependencies: 219
-- Name: vendas_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.vendas_id_seq', 7, true);


--
-- TOC entry 4708 (class 2606 OID 16444)
-- Name: produtos UNIQUE_CODIGO_DE_BARRAS; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.produtos
    ADD CONSTRAINT "UNIQUE_CODIGO_DE_BARRAS" UNIQUE (codigodebarras);


--
-- TOC entry 4704 (class 2606 OID 16469)
-- Name: clientes UNIQUE_CPF; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.clientes
    ADD CONSTRAINT "UNIQUE_CPF" UNIQUE (cpf);


--
-- TOC entry 4706 (class 2606 OID 16405)
-- Name: clientes clientes_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.clientes
    ADD CONSTRAINT clientes_pkey PRIMARY KEY (id);


--
-- TOC entry 4710 (class 2606 OID 16434)
-- Name: produtos produtos_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.produtos
    ADD CONSTRAINT produtos_pkey PRIMARY KEY (id);


--
-- TOC entry 4714 (class 2606 OID 16440)
-- Name: vendas vendas_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.vendas
    ADD CONSTRAINT vendas_pkey PRIMARY KEY (id);


--
-- TOC entry 4711 (class 1259 OID 16467)
-- Name: fki_FK_CLIENTES_PRODUTOS; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX "fki_FK_CLIENTES_PRODUTOS" ON public.vendas USING btree (clienteid);


--
-- TOC entry 4712 (class 1259 OID 16461)
-- Name: fki_FK_CLIENTES_VENDAS; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX "fki_FK_CLIENTES_VENDAS" ON public.vendas USING btree (clienteid);


--
-- TOC entry 4715 (class 1259 OID 16485)
-- Name: fki_FK_CODIGOVENDAS_VENDAS; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX "fki_FK_CODIGOVENDAS_VENDAS" ON public.itensdavenda USING btree (codigodavenda);


--
-- TOC entry 4716 (class 2606 OID 16462)
-- Name: vendas FK_CLIENTES_PRODUTOS; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.vendas
    ADD CONSTRAINT "FK_CLIENTES_PRODUTOS" FOREIGN KEY (clienteid) REFERENCES public.clientes(id) ON UPDATE RESTRICT ON DELETE RESTRICT;


-- Completed on 2024-05-31 11:06:44

--
-- PostgreSQL database dump complete
--

