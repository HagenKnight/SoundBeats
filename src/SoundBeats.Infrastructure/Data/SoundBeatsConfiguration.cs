﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SoundBeats.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundBeats.Infrastructure.Data
{
    public class SoundBeatsConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.ToTable("Country");

            builder.HasData(
                new Country { Id = 1, ISO2 = "AD", ISO3 = "AND", NameEn = " ", NameEs = "Andorra" },
                new Country { Id = 2, ISO2 = "AE", ISO3 = "ARE", NameEn = " ", NameEs = "Emiratos Árabes Unidos" },
                new Country { Id = 3, ISO2 = "AF", ISO3 = "AFG", NameEn = " ", NameEs = "Afganistán" },
                new Country { Id = 4, ISO2 = "AG", ISO3 = "ATG", NameEn = " ", NameEs = "Antigua y Barbuda" },
                new Country { Id = 5, ISO2 = "AI", ISO3 = "AIA", NameEn = " ", NameEs = "Anguila" },
                new Country { Id = 6, ISO2 = "AL", ISO3 = "ALB", NameEn = " ", NameEs = "Albania" },
                new Country { Id = 7, ISO2 = "AL", ISO3 = "ALB", NameEn = " ", NameEs = "Albania" },
                new Country { Id = 8, ISO2 = "AM", ISO3 = "ARM", NameEn = " ", NameEs = "Armenia" },
                new Country { Id = 9, ISO2 = "AN", ISO3 = "ANT", NameEn = " ", NameEs = "Antillas Holandesas" },
                new Country { Id = 10, ISO2 = "AO", ISO3 = "AGO", NameEn = " ", NameEs = "Angola" },
                new Country { Id = 11, ISO2 = "AQ", ISO3 = "ATA", NameEn = " ", NameEs = "Antártida" },
                new Country { Id = 12, ISO2 = "AR", ISO3 = "ARG", NameEn = " ", NameEs = "Argentina" },
                new Country { Id = 13, ISO2 = "AS", ISO3 = "ASM", NameEn = " ", NameEs = "Samoa Americana" },
                new Country { Id = 14, ISO2 = "AT", ISO3 = "AUT", NameEn = " ", NameEs = "Austria" },
                new Country { Id = 15, ISO2 = "AU", ISO3 = "AUS", NameEn = " ", NameEs = "Australia" },
                new Country { Id = 16, ISO2 = "AW", ISO3 = "ABW", NameEn = " ", NameEs = "Aruba" },
                new Country { Id = 17, ISO2 = "AX", ISO3 = "ALA", NameEn = " ", NameEs = "Islas Aland" },
                new Country { Id = 18, ISO2 = "AZ", ISO3 = "AZE", NameEn = " ", NameEs = "Azerbaiyán" },
                new Country { Id = 19, ISO2 = "BA", ISO3 = "BIH", NameEn = " ", NameEs = "Bosnia y Herzegovina" },
                new Country { Id = 20, ISO2 = "BB", ISO3 = "BRB", NameEn = " ", NameEs = "Barbados" },
                new Country { Id = 21, ISO2 = "BD", ISO3 = "BGD", NameEn = " ", NameEs = "Bangladesh" },
                new Country { Id = 22, ISO2 = "BE", ISO3 = "BEL", NameEn = " ", NameEs = "Bélgica" },
                new Country { Id = 23, ISO2 = "BF", ISO3 = "BFA", NameEn = " ", NameEs = "Burkina Faso" },
                new Country { Id = 24, ISO2 = "BG", ISO3 = "BGR", NameEn = " ", NameEs = "Bulgaria" },
                new Country { Id = 25, ISO2 = "BH", ISO3 = "BHR", NameEn = " ", NameEs = "Bahrein" },
                new Country { Id = 26, ISO2 = "BI", ISO3 = "BDI", NameEn = " ", NameEs = "Burundi" },
                new Country { Id = 27, ISO2 = "BJ", ISO3 = "BEN", NameEn = " ", NameEs = "Benín" },
                new Country { Id = 28, ISO2 = "BM", ISO3 = "BMU", NameEn = " ", NameEs = "Bermudas" },
                new Country { Id = 29, ISO2 = "BN", ISO3 = "BRN", NameEn = " ", NameEs = "Brunei" },
                new Country { Id = 30, ISO2 = "BO", ISO3 = "BOL", NameEn = " ", NameEs = "Bolivia" },
                new Country { Id = 31, ISO2 = "BR", ISO3 = "BRA", NameEn = " ", NameEs = "Brasil" },
                new Country { Id = 32, ISO2 = "BS", ISO3 = "BHS", NameEn = " ", NameEs = "Bahamas" },
                new Country { Id = 33, ISO2 = "BT", ISO3 = "BTN", NameEn = " ", NameEs = "Bután" },
                new Country { Id = 34, ISO2 = "BV", ISO3 = "BVT", NameEn = " ", NameEs = "Isla Bouvet" },
                new Country { Id = 35, ISO2 = "BW", ISO3 = "BWA", NameEn = " ", NameEs = "Botswana" },
                new Country { Id = 36, ISO2 = "BY", ISO3 = "BLR", NameEn = " ", NameEs = "Bielorusia" },
                new Country { Id = 37, ISO2 = "BZ", ISO3 = "BLZ", NameEn = " ", NameEs = "Belice" },
                new Country { Id = 38, ISO2 = "CA", ISO3 = "CAN", NameEn = " ", NameEs = "Canadá" },
                new Country { Id = 39, ISO2 = "CC", ISO3 = "CCK", NameEn = " ", NameEs = "Islas Cocos" },
                new Country { Id = 40, ISO2 = "CD", ISO3 = "COD", NameEn = " ", NameEs = "Republica Democrática del Congo" },
                new Country { Id = 41, ISO2 = "CF", ISO3 = "CAF", NameEn = " ", NameEs = "República Centrofricana" },
                new Country { Id = 42, ISO2 = "CG", ISO3 = "COG", NameEn = " ", NameEs = "República del Congo" },
                new Country { Id = 43, ISO2 = "CH", ISO3 = "CHE", NameEn = " ", NameEs = "Suiza" },
                new Country { Id = 44, ISO2 = "CI", ISO3 = "CIV", NameEn = " ", NameEs = "Costa de Marfil" },
                new Country { Id = 45, ISO2 = "CK", ISO3 = "COK", NameEn = " ", NameEs = "Islas Cook" },
                new Country { Id = 46, ISO2 = "CL", ISO3 = "CHL", NameEn = " ", NameEs = "Chile" },
                new Country { Id = 47, ISO2 = "CM", ISO3 = "CMR", NameEn = " ", NameEs = "Camerún" },
                new Country { Id = 48, ISO2 = "CN", ISO3 = "CHN", NameEn = " ", NameEs = "China" },
                new Country { Id = 49, ISO2 = "CO", ISO3 = "COL", NameEn = " ", NameEs = "Colombia" },
                new Country { Id = 50, ISO2 = "CR", ISO3 = "CRI", NameEn = " ", NameEs = "Costa Rica" },
                new Country { Id = 51, ISO2 = "CU", ISO3 = "CUB", NameEn = " ", NameEs = "Cuba" },
                new Country { Id = 52, ISO2 = "CV", ISO3 = "CPV", NameEn = " ", NameEs = "Cabo Verde" },
                new Country { Id = 53, ISO2 = "CX", ISO3 = "CXR", NameEn = " ", NameEs = "Isla de Navidad" },
                new Country { Id = 54, ISO2 = "CY", ISO3 = "CYP", NameEn = " ", NameEs = "Chipre" },
                new Country { Id = 55, ISO2 = "CZ", ISO3 = "CZE", NameEn = " ", NameEs = "República Checa" },
                new Country { Id = 56, ISO2 = "DE", ISO3 = "DEU", NameEn = " ", NameEs = "Alemania" },
                new Country { Id = 57, ISO2 = "DJ", ISO3 = "DJI", NameEn = " ", NameEs = "Yibuti" },
                new Country { Id = 58, ISO2 = "DK", ISO3 = "DNK", NameEn = " ", NameEs = "Dinamarca" },
                new Country { Id = 59, ISO2 = "DM", ISO3 = "DMA", NameEn = " ", NameEs = "Dominica" },
                new Country { Id = 60, ISO2 = "DO", ISO3 = "DOM", NameEn = " ", NameEs = "República Dominicana" },
                new Country { Id = 61, ISO2 = "DZ", ISO3 = "DZA", NameEn = " ", NameEs = "Argelia" },
                new Country { Id = 62, ISO2 = "EC", ISO3 = "ECU", NameEn = " ", NameEs = "Ecuador" },
                new Country { Id = 63, ISO2 = "EE", ISO3 = "EST", NameEn = " ", NameEs = "Estonia" },
                new Country { Id = 64, ISO2 = "EG", ISO3 = "EGY", NameEn = " ", NameEs = "Egipto" },
                new Country { Id = 65, ISO2 = "EH", ISO3 = "ESH", NameEn = " ", NameEs = "Sahara Occidental" },
                new Country { Id = 66, ISO2 = "ER", ISO3 = "ERI", NameEn = " ", NameEs = "Eritrea" },
                new Country { Id = 67, ISO2 = "ES", ISO3 = "ESP", NameEn = " ", NameEs = "España" },
                new Country { Id = 68, ISO2 = "ET", ISO3 = "ETH", NameEn = " ", NameEs = "Etiopía" },
                new Country { Id = 69, ISO2 = "FI", ISO3 = "FIN", NameEn = " ", NameEs = "Finlandia" },
                new Country { Id = 70, ISO2 = "FJ", ISO3 = "FJI", NameEn = " ", NameEs = "Fiji" },
                new Country { Id = 71, ISO2 = "FK", ISO3 = "FLK", NameEn = " ", NameEs = "Islas Malvinas" },
                new Country { Id = 72, ISO2 = "FM", ISO3 = "FSM", NameEn = " ", NameEs = "Micronesia" },
                new Country { Id = 73, ISO2 = "FO", ISO3 = "FRO", NameEn = " ", NameEs = "Islas Faroe" },
                new Country { Id = 74, ISO2 = "FR", ISO3 = "FRA", NameEn = " ", NameEs = "Francia" },
                new Country { Id = 75, ISO2 = "GA", ISO3 = "GAB", NameEn = " ", NameEs = "Gabón" },
                new Country { Id = 76, ISO2 = "GB", ISO3 = "GBR", NameEn = " ", NameEs = "Reino Unido" },
                new Country { Id = 77, ISO2 = "GD", ISO3 = "GRD", NameEn = " ", NameEs = "Granada" },
                new Country { Id = 78, ISO2 = "GE", ISO3 = "GEO", NameEn = " ", NameEs = "Georgia" },
                new Country { Id = 79, ISO2 = "GF", ISO3 = "GUF", NameEn = " ", NameEs = "Guayana Francesa" },
                new Country { Id = 80, ISO2 = "GG", ISO3 = "GGY", NameEn = " ", NameEs = "Guernsey" },
                new Country { Id = 81, ISO2 = "GH", ISO3 = "GHA", NameEn = " ", NameEs = "Ghana" },
                new Country { Id = 82, ISO2 = "GI", ISO3 = "GIB", NameEn = " ", NameEs = "Gibraltar" },
                new Country { Id = 83, ISO2 = "GL", ISO3 = "GRL", NameEn = " ", NameEs = "Groenlandia" },
                new Country { Id = 84, ISO2 = "GM", ISO3 = "GMB", NameEn = " ", NameEs = "Gambia" },
                new Country { Id = 85, ISO2 = "GN", ISO3 = "GIN", NameEn = " ", NameEs = "Guinea" },
                new Country { Id = 86, ISO2 = "GP", ISO3 = "GLP", NameEn = " ", NameEs = "Guadalupe" },
                new Country { Id = 87, ISO2 = "GQ", ISO3 = "GNQ", NameEn = " ", NameEs = "Guinea Ecuatorial" },
                new Country { Id = 88, ISO2 = "GR", ISO3 = "GRC", NameEn = " ", NameEs = "Grecia" },
                new Country { Id = 89, ISO2 = "GS", ISO3 = "SGS", NameEn = " ", NameEs = "Georgia del Sur y las islas Sandwich" },
                new Country { Id = 90, ISO2 = "GT", ISO3 = "GTM", NameEn = " ", NameEs = "Guatemala" },
                new Country { Id = 91, ISO2 = "GU", ISO3 = "GUM", NameEn = " ", NameEs = "Guam" },
                new Country { Id = 92, ISO2 = "GW", ISO3 = "GNB", NameEn = " ", NameEs = "Guinea-Bissau" },
                new Country { Id = 93, ISO2 = "GY", ISO3 = "GUY", NameEn = " ", NameEs = "Guyana" },
                new Country { Id = 94, ISO2 = "HK", ISO3 = "HKG", NameEn = " ", NameEs = "Hong Kong" },
                new Country { Id = 95, ISO2 = "HM", ISO3 = "HMD", NameEn = " ", NameEs = "Islas Heard y McDonald" },
                new Country { Id = 96, ISO2 = "HN", ISO3 = "HND", NameEn = " ", NameEs = "Honduras" },
                new Country { Id = 97, ISO2 = "HR", ISO3 = "HRV", NameEn = " ", NameEs = "Croacia" },
                new Country { Id = 98, ISO2 = "HT", ISO3 = "HTI", NameEn = " ", NameEs = "Haití" },
                new Country { Id = 99, ISO2 = "HU", ISO3 = "HUN", NameEn = " ", NameEs = "Hungría" },
                new Country { Id = 100, ISO2 = "ID", ISO3 = "IDN", NameEn = " ", NameEs = "Indonesia" },
                new Country { Id = 101, ISO2 = "IE", ISO3 = "IRL", NameEn = " ", NameEs = "Irlanda" },
                new Country { Id = 102, ISO2 = "IL", ISO3 = "ISR", NameEn = " ", NameEs = "Israel" },
                new Country { Id = 103, ISO2 = "IM", ISO3 = "IMN", NameEn = " ", NameEs = "Isla de Man" },
                new Country { Id = 104, ISO2 = "IN", ISO3 = "IND", NameEn = " ", NameEs = "India" },
                new Country { Id = 105, ISO2 = "IO", ISO3 = "IOT", NameEn = " ", NameEs = "Terrirorio Británico del Océano Índico" },
                new Country { Id = 106, ISO2 = "IQ", ISO3 = "IRQ", NameEn = " ", NameEs = "Irak" },
                new Country { Id = 107, ISO2 = "IR", ISO3 = "IRN", NameEn = " ", NameEs = "Irán" },
                new Country { Id = 108, ISO2 = "IS", ISO3 = "ISL", NameEn = " ", NameEs = "Islandia" },
                new Country { Id = 109, ISO2 = "IT", ISO3 = "ITA", NameEn = " ", NameEs = "Italia" },
                new Country { Id = 110, ISO2 = "JE", ISO3 = "JEY", NameEn = " ", NameEs = "Jersey" },
                new Country { Id = 111, ISO2 = "JM", ISO3 = "JAM", NameEn = " ", NameEs = "Jamaica" },
                new Country { Id = 112, ISO2 = "JO", ISO3 = "JOR", NameEn = " ", NameEs = "Jordania" },
                new Country { Id = 113, ISO2 = "JP", ISO3 = "JPN", NameEn = " ", NameEs = "Japón" },
                new Country { Id = 114, ISO2 = "KE", ISO3 = "KEN", NameEn = " ", NameEs = "Kenia" },
                new Country { Id = 115, ISO2 = "KG", ISO3 = "KGZ", NameEn = " ", NameEs = "Kirguistán" },
                new Country { Id = 116, ISO2 = "KH", ISO3 = "KHM", NameEn = " ", NameEs = "Camboya" },
                new Country { Id = 117, ISO2 = "KI", ISO3 = "KIR", NameEn = " ", NameEs = "Kiribati" },
                new Country { Id = 118, ISO2 = "KM", ISO3 = "COM", NameEn = " ", NameEs = "Comoras" },
                new Country { Id = 119, ISO2 = "KN", ISO3 = "KNA", NameEn = " ", NameEs = "San Cristóbal y Nieves" },
                new Country { Id = 120, ISO2 = "KP", ISO3 = "PRK", NameEn = " ", NameEs = "República Democrática de Corea" },
                new Country { Id = 121, ISO2 = "KR", ISO3 = "KOR", NameEn = " ", NameEs = "República de Corea" },
                new Country { Id = 122, ISO2 = "KW", ISO3 = "KWT", NameEn = " ", NameEs = "Kuwait" },
                new Country { Id = 123, ISO2 = "KY", ISO3 = "CYM", NameEn = " ", NameEs = "Islas Caimán" },
                new Country { Id = 124, ISO2 = "KZ", ISO3 = "KAZ", NameEn = " ", NameEs = "Kasajistán" },
                new Country { Id = 125, ISO2 = "LA", ISO3 = "LAO", NameEn = " ", NameEs = "Laos" },
                new Country { Id = 126, ISO2 = "LB", ISO3 = "LBN", NameEn = " ", NameEs = "Líbano" },
                new Country { Id = 127, ISO2 = "LC", ISO3 = "LCA", NameEn = " ", NameEs = "Santa Lucía" },
                new Country { Id = 128, ISO2 = "LI", ISO3 = "LIE", NameEn = " ", NameEs = "Liechtenstein" },
                new Country { Id = 129, ISO2 = "LK", ISO3 = "LKA", NameEn = " ", NameEs = "Sri Lanka" },
                new Country { Id = 130, ISO2 = "LR", ISO3 = "LBR", NameEn = " ", NameEs = "Liberia" },
                new Country { Id = 131, ISO2 = "LS", ISO3 = "LSO", NameEn = " ", NameEs = "Lesotho" },
                new Country { Id = 132, ISO2 = "LT", ISO3 = "LTU", NameEn = " ", NameEs = "Lituana" },
                new Country { Id = 133, ISO2 = "LU", ISO3 = "LUX", NameEn = " ", NameEs = "Luxembur " },
                new Country { Id = 134, ISO2 = "LV", ISO3 = "LVA", NameEn = " ", NameEs = "Letonia" },
                new Country { Id = 135, ISO2 = "LY", ISO3 = "LBY", NameEn = " ", NameEs = "Libia" },
                new Country { Id = 136, ISO2 = "MA", ISO3 = "MAR", NameEn = " ", NameEs = "Marruecos" },
                new Country { Id = 137, ISO2 = "MC", ISO3 = "MCO", NameEn = " ", NameEs = "Mónaco" },
                new Country { Id = 138, ISO2 = "MD", ISO3 = "MDA", NameEn = " ", NameEs = "Moldavia" },
                new Country { Id = 139, ISO2 = "ME", ISO3 = "MNE", NameEn = " ", NameEs = "Montenegro" },
                new Country { Id = 140, ISO2 = "MG", ISO3 = "MDG", NameEn = " ", NameEs = "Madagascar" },
                new Country { Id = 141, ISO2 = "MH", ISO3 = "MHL", NameEn = " ", NameEs = "Islas Marschall" },
                new Country { Id = 142, ISO2 = "MK", ISO3 = "MKD", NameEn = " ", NameEs = "Macedonia" },
                new Country { Id = 143, ISO2 = "ML", ISO3 = "MLI", NameEn = " ", NameEs = "Malí" },
                new Country { Id = 144, ISO2 = "MM", ISO3 = "MMR", NameEn = " ", NameEs = "Myanmar" },
                new Country { Id = 145, ISO2 = "MN", ISO3 = "MNG", NameEn = " ", NameEs = "Mon lia" },
                new Country { Id = 146, ISO2 = "MO", ISO3 = "MAC", NameEn = " ", NameEs = "Macao" },
                new Country { Id = 147, ISO2 = "MP", ISO3 = "MNP", NameEn = " ", NameEs = "Islas Marianas del Norte" },
                new Country { Id = 148, ISO2 = "MQ", ISO3 = "MTQ", NameEn = " ", NameEs = "Martinica" },
                new Country { Id = 149, ISO2 = "MR", ISO3 = "MRT", NameEn = " ", NameEs = "Mauritania" },
                new Country { Id = 150, ISO2 = "MS", ISO3 = "MSR", NameEn = " ", NameEs = "Montserrat" },
                new Country { Id = 151, ISO2 = "MT", ISO3 = "MLT", NameEn = " ", NameEs = "Malta" },
                new Country { Id = 152, ISO2 = "MU", ISO3 = "MUS", NameEn = " ", NameEs = "Mauricio" },
                new Country { Id = 153, ISO2 = "MV", ISO3 = "MDV", NameEn = " ", NameEs = "Maldivas" },
                new Country { Id = 154, ISO2 = "MW", ISO3 = "MWI", NameEn = " ", NameEs = "Malawi" },
                new Country { Id = 155, ISO2 = "MX", ISO3 = "MEX", NameEn = " ", NameEs = "México" },
                new Country { Id = 156, ISO2 = "MY", ISO3 = "MYS", NameEn = " ", NameEs = "Malasia" },
                new Country { Id = 157, ISO2 = "MZ", ISO3 = "MOZ", NameEn = " ", NameEs = "Mozambique" },
                new Country { Id = 158, ISO2 = "NA", ISO3 = "NAM", NameEn = " ", NameEs = "Namibia" },
                new Country { Id = 159, ISO2 = "NC", ISO3 = "NCL", NameEn = " ", NameEs = "Nueva Caledonia" },
                new Country { Id = 160, ISO2 = "NE", ISO3 = "NER", NameEn = " ", NameEs = "Níger" },
                new Country { Id = 161, ISO2 = "NF", ISO3 = "NFK", NameEn = " ", NameEs = "Isla Norfolk" },
                new Country { Id = 162, ISO2 = "NG", ISO3 = "NGA", NameEn = " ", NameEs = "Nigeria" },
                new Country { Id = 163, ISO2 = "NI", ISO3 = "NIC", NameEn = " ", NameEs = "Nicaragua" },
                new Country { Id = 164, ISO2 = "NL", ISO3 = "NLD", NameEn = " ", NameEs = "Países Bajos" },
                new Country { Id = 165, ISO2 = "NO", ISO3 = "NOR", NameEn = " ", NameEs = "Noruega" },
                new Country { Id = 166, ISO2 = "NP", ISO3 = "NPL", NameEn = " ", NameEs = "Nepal" },
                new Country { Id = 167, ISO2 = "NR", ISO3 = "NRU", NameEn = " ", NameEs = "Naurú" },
                new Country { Id = 168, ISO2 = "NU", ISO3 = "NIU", NameEn = " ", NameEs = "Niue" },
                new Country { Id = 169, ISO2 = "NZ", ISO3 = "NZL", NameEn = " ", NameEs = "Nueva Zelanda" },
                new Country { Id = 170, ISO2 = "OM", ISO3 = "OMN", NameEn = " ", NameEs = "Omán" },
                new Country { Id = 171, ISO2 = "PA", ISO3 = "PAN", NameEn = " ", NameEs = "Panamá" },
                new Country { Id = 172, ISO2 = "PE", ISO3 = "PER", NameEn = " ", NameEs = "Perú" },
                new Country { Id = 173, ISO2 = "PF", ISO3 = "PYF", NameEn = " ", NameEs = "Polinesia Francesa" },
                new Country { Id = 174, ISO2 = "PG", ISO3 = "PNG", NameEn = " ", NameEs = "Papúa-Nueva Guinea" },
                new Country { Id = 175, ISO2 = "PH", ISO3 = "PHL", NameEn = " ", NameEs = "Filipinas" },
                new Country { Id = 176, ISO2 = "PK", ISO3 = "PAK", NameEn = " ", NameEs = "Pakistán" },
                new Country { Id = 177, ISO2 = "PL", ISO3 = "POL", NameEn = " ", NameEs = "Polonia" },
                new Country { Id = 178, ISO2 = "PM", ISO3 = "SPM", NameEn = " ", NameEs = "San Pedro y Miquelón" },
                new Country { Id = 179, ISO2 = "PN", ISO3 = "PCN", NameEn = " ", NameEs = "Pitcairn" },
                new Country { Id = 180, ISO2 = "PR", ISO3 = "PRI", NameEn = " ", NameEs = "Puerto Rico" },
                new Country { Id = 181, ISO2 = "PS", ISO3 = "PSE", NameEn = " ", NameEs = "Estado de Palestina" },
                new Country { Id = 182, ISO2 = "PT", ISO3 = "PRT", NameEn = " ", NameEs = "Portugal" },
                new Country { Id = 183, ISO2 = "PW", ISO3 = "PLW", NameEn = " ", NameEs = "Palau" },
                new Country { Id = 184, ISO2 = "PY", ISO3 = "PRY", NameEn = " ", NameEs = "Paraguay" },
                new Country { Id = 185, ISO2 = "QA", ISO3 = "QAT", NameEn = " ", NameEs = "Qatar" },
                new Country { Id = 186, ISO2 = "RE", ISO3 = "REU", NameEn = " ", NameEs = "Reunión" },
                new Country { Id = 187, ISO2 = "RO", ISO3 = "ROM", NameEn = " ", NameEs = "Rumania" },
                new Country { Id = 188, ISO2 = "RS", ISO3 = "SRB", NameEn = " ", NameEs = "Serbia" },
                new Country { Id = 189, ISO2 = "RU", ISO3 = "RUS", NameEn = " ", NameEs = "Rusia" },
                new Country { Id = 190, ISO2 = "RW", ISO3 = "RWA", NameEn = " ", NameEs = "Ruanda" },
                new Country { Id = 191, ISO2 = "SA", ISO3 = "SAU", NameEn = " ", NameEs = "Arabia Saudita" },
                new Country { Id = 192, ISO2 = "SB", ISO3 = "SLB", NameEn = " ", NameEs = "Islas Salomón" },
                new Country { Id = 193, ISO2 = "SC", ISO3 = "SYC", NameEn = " ", NameEs = "Seychelles" },
                new Country { Id = 194, ISO2 = "SD", ISO3 = "SDN", NameEn = " ", NameEs = "Sudán" },
                new Country { Id = 195, ISO2 = "SE", ISO3 = "SWE", NameEn = " ", NameEs = "Suecia" },
                new Country { Id = 196, ISO2 = "SG", ISO3 = "SGP", NameEn = " ", NameEs = "Singapur" },
                new Country { Id = 197, ISO2 = "SH", ISO3 = "SHN", NameEn = " ", NameEs = "Santa Helena" },
                new Country { Id = 198, ISO2 = "SI", ISO3 = "SVN", NameEn = " ", NameEs = "Eslovenia" },
                new Country { Id = 199, ISO2 = "SJ", ISO3 = "SJM", NameEn = " ", NameEs = "Svalbard y Jan Mayen" },
                new Country { Id = 200, ISO2 = "SK", ISO3 = "SVK", NameEn = " ", NameEs = "Eslovaquia" },
                new Country { Id = 201, ISO2 = "SL", ISO3 = "SLE", NameEn = " ", NameEs = "Sierra Leona" },
                new Country { Id = 202, ISO2 = "SM", ISO3 = "SMR", NameEn = " ", NameEs = "San Marino" },
                new Country { Id = 203, ISO2 = "SN", ISO3 = "SEN", NameEn = " ", NameEs = "Senegal" },
                new Country { Id = 204, ISO2 = "SO", ISO3 = "SOM", NameEn = " ", NameEs = "Somalia" },
                new Country { Id = 205, ISO2 = "SR", ISO3 = "SUR", NameEn = " ", NameEs = "Surinam" },
                new Country { Id = 206, ISO2 = "ST", ISO3 = "STP", NameEn = " ", NameEs = "Santo Tomé y Príncipe" },
                new Country { Id = 207, ISO2 = "SV", ISO3 = "SLV", NameEn = " ", NameEs = "El Salvador" },
                new Country { Id = 208, ISO2 = "SY", ISO3 = "SYR", NameEn = " ", NameEs = "Siria" },
                new Country { Id = 209, ISO2 = "SZ", ISO3 = "SWZ", NameEn = " ", NameEs = "Swazilandia" },
                new Country { Id = 210, ISO2 = "TC", ISO3 = "TCA", NameEn = " ", NameEs = "Isla Turks y Caicos" },
                new Country { Id = 211, ISO2 = "TD", ISO3 = "TCD", NameEn = " ", NameEs = "Chad" },
                new Country { Id = 212, ISO2 = "TF", ISO3 = "ATF", NameEn = " ", NameEs = "Territorios Franceses del Sur" },
                new Country { Id = 213, ISO2 = "TG", ISO3 = "TGO", NameEn = " ", NameEs = "Togo" },
                new Country { Id = 214, ISO2 = "TH", ISO3 = "THA", NameEn = " ", NameEs = "Tailandia" },
                new Country { Id = 215, ISO2 = "TJ", ISO3 = "TJK", NameEn = " ", NameEs = "Tajikistán" },
                new Country { Id = 216, ISO2 = "TK", ISO3 = "TKL", NameEn = " ", NameEs = "Tokelau" },
                new Country { Id = 217, ISO2 = "TL", ISO3 = "TKM", NameEn = " ", NameEs = "Timor Este" },
                new Country { Id = 218, ISO2 = "TM", ISO3 = "TUN", NameEn = " ", NameEs = "Turkmenistán" },
                new Country { Id = 219, ISO2 = "TN", ISO3 = "TON", NameEn = " ", NameEs = "Tunicia" },
                new Country { Id = 220, ISO2 = "TO", ISO3 = "TMP", NameEn = " ", NameEs = "Tonga" },
                new Country { Id = 221, ISO2 = "TR", ISO3 = "TUR", NameEn = " ", NameEs = "Turquía" },
                new Country { Id = 222, ISO2 = "TT", ISO3 = "TTO", NameEn = " ", NameEs = "Trinidad y Toba " },
                new Country { Id = 223, ISO2 = "TV", ISO3 = "TUV", NameEn = " ", NameEs = "Tuvalú" },
                new Country { Id = 224, ISO2 = "TW", ISO3 = "TWN", NameEn = " ", NameEs = "Taiwán" },
                new Country { Id = 225, ISO2 = "TZ", ISO3 = "TZA", NameEn = " ", NameEs = "Tanzania" },
                new Country { Id = 226, ISO2 = "UA", ISO3 = "UKR", NameEn = " ", NameEs = "Ucrania" },
                new Country { Id = 227, ISO2 = "UG", ISO3 = "UGA", NameEn = " ", NameEs = "Uganda" },
                new Country { Id = 228, ISO2 = "UM", ISO3 = "UMI", NameEn = " ", NameEs = "Islas Menores de Estados Unidos" },
                new Country { Id = 229, ISO2 = "US", ISO3 = "USA", NameEn = " ", NameEs = "Estados Unidos" },
                new Country { Id = 230, ISO2 = "UY", ISO3 = "URY", NameEn = " ", NameEs = "Uruguay" },
                new Country { Id = 231, ISO2 = "UZ", ISO3 = "UZB", NameEn = " ", NameEs = "Uzbekistán" },
                new Country { Id = 232, ISO2 = "VA", ISO3 = "VAT", NameEn = " ", NameEs = "El Vaticano" },
                new Country { Id = 233, ISO2 = "VC", ISO3 = "VCT", NameEn = " ", NameEs = "San Vicente y Granadinas" },
                new Country { Id = 234, ISO2 = "VE", ISO3 = "VEN", NameEn = " ", NameEs = "Venezuela" },
                new Country { Id = 235, ISO2 = "VG", ISO3 = "VGB", NameEn = " ", NameEs = "Islas Vírgenes Británicas" },
                new Country { Id = 236, ISO2 = "VI", ISO3 = "VIR", NameEn = " ", NameEs = "Islas Vírgenes de Estados Unidos" },
                new Country { Id = 237, ISO2 = "VN", ISO3 = "VNM", NameEn = " ", NameEs = "Vietnam" },
                new Country { Id = 238, ISO2 = "VU", ISO3 = "VUT", NameEn = " ", NameEs = "Vanuatu" },
                new Country { Id = 239, ISO2 = "WF", ISO3 = "WLF", NameEn = " ", NameEs = "Wallis y Futuna" },
                new Country { Id = 240, ISO2 = "WS", ISO3 = "WSM", NameEn = " ", NameEs = "Samoa" },
                new Country { Id = 241, ISO2 = "YE", ISO3 = "YEM", NameEn = " ", NameEs = "Yemén" },
                new Country { Id = 242, ISO2 = "YT", ISO3 = "MYT", NameEn = " ", NameEs = "Mayotte" },
                new Country { Id = 243, ISO2 = "ZA", ISO3 = "ZAF", NameEn = " ", NameEs = "Suráfrica" },
                new Country { Id = 244, ISO2 = "ZM", ISO3 = "ZMB", NameEn = " ", NameEs = "Zambia" },
                new Country { Id = 245, ISO2 = "ZW", ISO3 = "ZWE", NameEn = " ", NameEs = "Zimbabwe" }
                );
        }
    }
}
