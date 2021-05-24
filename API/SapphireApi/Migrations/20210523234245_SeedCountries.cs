using Microsoft.EntityFrameworkCore.Migrations;

namespace SapphireApi.Migrations
{
    public partial class SeedCountries : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ADM_OCRY",
                columns: new[] { "id", "createdBy", "key", "name", "objType", "updatedBy" },
                values: new object[,]
                {
                    { 1, "40709ea0-0908-4bea-8468-433bd706cedd", "AF", "Afghanistan", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 158, "40709ea0-0908-4bea-8468-433bd706cedd", "NC", "New Caledonia", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 159, "40709ea0-0908-4bea-8468-433bd706cedd", "NZ", "New Zealand", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 160, "40709ea0-0908-4bea-8468-433bd706cedd", "NI", "Nicaragua", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 161, "40709ea0-0908-4bea-8468-433bd706cedd", "NE", "Niger", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 162, "40709ea0-0908-4bea-8468-433bd706cedd", "NG", "Nigeria", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 163, "40709ea0-0908-4bea-8468-433bd706cedd", "NU", "Niue", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 164, "40709ea0-0908-4bea-8468-433bd706cedd", "NF", "Norfolk Island", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 165, "40709ea0-0908-4bea-8468-433bd706cedd", "MP", "Northern Mariana Islands", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 166, "40709ea0-0908-4bea-8468-433bd706cedd", "NO", "Norway", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 167, "40709ea0-0908-4bea-8468-433bd706cedd", "OM", "Oman", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 168, "40709ea0-0908-4bea-8468-433bd706cedd", "PK", "Pakistan", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 169, "40709ea0-0908-4bea-8468-433bd706cedd", "PW", "Palau", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 170, "40709ea0-0908-4bea-8468-433bd706cedd", "PS", "Palestine, State of", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 171, "40709ea0-0908-4bea-8468-433bd706cedd", "PA", "Panama", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 172, "40709ea0-0908-4bea-8468-433bd706cedd", "PG", "Papua New Guinea", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 173, "40709ea0-0908-4bea-8468-433bd706cedd", "PY", "Paraguay", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 174, "40709ea0-0908-4bea-8468-433bd706cedd", "PE", "Peru", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 175, "40709ea0-0908-4bea-8468-433bd706cedd", "PH", "Philippines", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 176, "40709ea0-0908-4bea-8468-433bd706cedd", "PN", "Pitcairn", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 177, "40709ea0-0908-4bea-8468-433bd706cedd", "PL", "Poland", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 178, "40709ea0-0908-4bea-8468-433bd706cedd", "PT", "Portugal", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 179, "40709ea0-0908-4bea-8468-433bd706cedd", "PR", "Puerto Rico", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 180, "40709ea0-0908-4bea-8468-433bd706cedd", "QA", "Qatar", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 181, "40709ea0-0908-4bea-8468-433bd706cedd", "RE", "Réunion", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 182, "40709ea0-0908-4bea-8468-433bd706cedd", "RO", "Romania", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 183, "40709ea0-0908-4bea-8468-433bd706cedd", "RU", "Russian Federation", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 184, "40709ea0-0908-4bea-8468-433bd706cedd", "RW", "Rwanda", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 157, "40709ea0-0908-4bea-8468-433bd706cedd", "NL", "Netherlands", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 185, "40709ea0-0908-4bea-8468-433bd706cedd", "BL", "Saint Barthélemy", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 156, "40709ea0-0908-4bea-8468-433bd706cedd", "NP", "Nepal", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 154, "40709ea0-0908-4bea-8468-433bd706cedd", "NA", "Namibia", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 127, "40709ea0-0908-4bea-8468-433bd706cedd", "LY", "Libya", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 128, "40709ea0-0908-4bea-8468-433bd706cedd", "LI", "Liechtenstein", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 129, "40709ea0-0908-4bea-8468-433bd706cedd", "LT", "Lithuania", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 130, "40709ea0-0908-4bea-8468-433bd706cedd", "LU", "Luxembourg", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 131, "40709ea0-0908-4bea-8468-433bd706cedd", "MO", "Macao", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 132, "40709ea0-0908-4bea-8468-433bd706cedd", "MK", "Macedonia, the Former Yugoslav Republic of", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 133, "40709ea0-0908-4bea-8468-433bd706cedd", "MG", "Madagascar", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 134, "40709ea0-0908-4bea-8468-433bd706cedd", "MW", "Malawi", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 135, "40709ea0-0908-4bea-8468-433bd706cedd", "MY", "Malaysia", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 136, "40709ea0-0908-4bea-8468-433bd706cedd", "MV", "Maldives", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 137, "40709ea0-0908-4bea-8468-433bd706cedd", "ML", "Mali", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 138, "40709ea0-0908-4bea-8468-433bd706cedd", "MT", "Malta", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 139, "40709ea0-0908-4bea-8468-433bd706cedd", "MH", "Marshall Islands", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 140, "40709ea0-0908-4bea-8468-433bd706cedd", "MQ", "Martinique", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 141, "40709ea0-0908-4bea-8468-433bd706cedd", "MR", "Mauritania", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 142, "40709ea0-0908-4bea-8468-433bd706cedd", "MU", "Mauritius", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 143, "40709ea0-0908-4bea-8468-433bd706cedd", "YT", "Mayotte", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 144, "40709ea0-0908-4bea-8468-433bd706cedd", "MX", "Mexico", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 145, "40709ea0-0908-4bea-8468-433bd706cedd", "FM", "Micronesia, Federated States of", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 146, "40709ea0-0908-4bea-8468-433bd706cedd", "MD", "Moldova, Republic of", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 147, "40709ea0-0908-4bea-8468-433bd706cedd", "MC", "Monaco", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 148, "40709ea0-0908-4bea-8468-433bd706cedd", "MN", "Mongolia", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 149, "40709ea0-0908-4bea-8468-433bd706cedd", "ME", "Montenegro", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 150, "40709ea0-0908-4bea-8468-433bd706cedd", "MS", "Montserrat", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 151, "40709ea0-0908-4bea-8468-433bd706cedd", "MA", "Morocco", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 152, "40709ea0-0908-4bea-8468-433bd706cedd", "MZ", "Mozambique", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 153, "40709ea0-0908-4bea-8468-433bd706cedd", "MM", "Myanmar", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 155, "40709ea0-0908-4bea-8468-433bd706cedd", "NR", "Nauru", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 186, "40709ea0-0908-4bea-8468-433bd706cedd", "SH", "Saint Helena, Ascension and Tristan da Cunha", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 187, "40709ea0-0908-4bea-8468-433bd706cedd", "KN", "Saint Kitts and Nevis", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 188, "40709ea0-0908-4bea-8468-433bd706cedd", "LC", "Saint Lucia", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 221, "40709ea0-0908-4bea-8468-433bd706cedd", "TH", "Thailand", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 222, "40709ea0-0908-4bea-8468-433bd706cedd", "TL", "Timor-Leste", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 223, "40709ea0-0908-4bea-8468-433bd706cedd", "TG", "Togo", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 224, "40709ea0-0908-4bea-8468-433bd706cedd", "TK", "Tokelau", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 225, "40709ea0-0908-4bea-8468-433bd706cedd", "TO", "Tonga", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 226, "40709ea0-0908-4bea-8468-433bd706cedd", "TT", "Trinidad and Tobago", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 227, "40709ea0-0908-4bea-8468-433bd706cedd", "TN", "Tunisia", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 228, "40709ea0-0908-4bea-8468-433bd706cedd", "TR", "Turkey", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 229, "40709ea0-0908-4bea-8468-433bd706cedd", "TM", "Turkmenistan", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 230, "40709ea0-0908-4bea-8468-433bd706cedd", "TC", "Turks and Caicos Islands", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 231, "40709ea0-0908-4bea-8468-433bd706cedd", "TV", "Tuvalu", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 232, "40709ea0-0908-4bea-8468-433bd706cedd", "UG", "Uganda", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 233, "40709ea0-0908-4bea-8468-433bd706cedd", "UA", "Ukraine", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 234, "40709ea0-0908-4bea-8468-433bd706cedd", "AE", "United Arab Emirates", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 235, "40709ea0-0908-4bea-8468-433bd706cedd", "GB", "United Kingdom", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 236, "40709ea0-0908-4bea-8468-433bd706cedd", "US", "United States", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 237, "40709ea0-0908-4bea-8468-433bd706cedd", "UM", "United States Minor Outlying Islands", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 238, "40709ea0-0908-4bea-8468-433bd706cedd", "UY", "Uruguay", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 239, "40709ea0-0908-4bea-8468-433bd706cedd", "UZ", "Uzbekistan", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 240, "40709ea0-0908-4bea-8468-433bd706cedd", "VU", "Vanuatu", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 241, "40709ea0-0908-4bea-8468-433bd706cedd", "VE", "Venezuela, Bolivarian Republic of", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 242, "40709ea0-0908-4bea-8468-433bd706cedd", "VN", "Viet Nam", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 243, "40709ea0-0908-4bea-8468-433bd706cedd", "VG", "Virgin Islands, British", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 244, "40709ea0-0908-4bea-8468-433bd706cedd", "VI", "Virgin Islands, U.S.", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 245, "40709ea0-0908-4bea-8468-433bd706cedd", "WF", "Wallis and Futuna", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 246, "40709ea0-0908-4bea-8468-433bd706cedd", "EH", "Western Sahara", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 247, "40709ea0-0908-4bea-8468-433bd706cedd", "YE", "Yemen", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 220, "40709ea0-0908-4bea-8468-433bd706cedd", "TZ", "Tanzania, United Republic of", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 219, "40709ea0-0908-4bea-8468-433bd706cedd", "TJ", "Tajikistan", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 218, "40709ea0-0908-4bea-8468-433bd706cedd", "TW", "Taiwan, Province of China", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 217, "40709ea0-0908-4bea-8468-433bd706cedd", "SY", "Syrian Arab Republic", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 189, "40709ea0-0908-4bea-8468-433bd706cedd", "MF", "Saint Martin (French part)", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 190, "40709ea0-0908-4bea-8468-433bd706cedd", "PM", "Saint Pierre and Miquelon", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 191, "40709ea0-0908-4bea-8468-433bd706cedd", "VC", "Saint Vincent and the Grenadines", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 192, "40709ea0-0908-4bea-8468-433bd706cedd", "WS", "Samoa", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 193, "40709ea0-0908-4bea-8468-433bd706cedd", "SM", "San Marino", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 194, "40709ea0-0908-4bea-8468-433bd706cedd", "ST", "Sao Tome and Principe", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 195, "40709ea0-0908-4bea-8468-433bd706cedd", "SA", "Saudi Arabia", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 196, "40709ea0-0908-4bea-8468-433bd706cedd", "SN", "Senegal", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 197, "40709ea0-0908-4bea-8468-433bd706cedd", "RS", "Serbia", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 198, "40709ea0-0908-4bea-8468-433bd706cedd", "SC", "Seychelles", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 199, "40709ea0-0908-4bea-8468-433bd706cedd", "SL", "Sierra Leone", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 200, "40709ea0-0908-4bea-8468-433bd706cedd", "SG", "Singapore", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 201, "40709ea0-0908-4bea-8468-433bd706cedd", "SX", "Sint Maarten (Dutch part)", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 126, "40709ea0-0908-4bea-8468-433bd706cedd", "LR", "Liberia", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 202, "40709ea0-0908-4bea-8468-433bd706cedd", "SK", "Slovakia", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 204, "40709ea0-0908-4bea-8468-433bd706cedd", "SB", "Solomon Islands", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 205, "40709ea0-0908-4bea-8468-433bd706cedd", "SO", "Somalia", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 206, "40709ea0-0908-4bea-8468-433bd706cedd", "ZA", "South Africa", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 207, "40709ea0-0908-4bea-8468-433bd706cedd", "GS", "South Georgia and the South Sandwich Islands", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 208, "40709ea0-0908-4bea-8468-433bd706cedd", "SS", "South Sudan", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 209, "40709ea0-0908-4bea-8468-433bd706cedd", "ES", "Spain", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 210, "40709ea0-0908-4bea-8468-433bd706cedd", "LK", "Sri Lanka", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 211, "40709ea0-0908-4bea-8468-433bd706cedd", "SD", "Sudan", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 212, "40709ea0-0908-4bea-8468-433bd706cedd", "SR", "Suriname", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 213, "40709ea0-0908-4bea-8468-433bd706cedd", "SJ", "Svalbard and Jan Mayen", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 214, "40709ea0-0908-4bea-8468-433bd706cedd", "SZ", "Swaziland", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 215, "40709ea0-0908-4bea-8468-433bd706cedd", "SE", "Sweden", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 216, "40709ea0-0908-4bea-8468-433bd706cedd", "CH", "Switzerland", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 203, "40709ea0-0908-4bea-8468-433bd706cedd", "SI", "Slovenia", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 248, "40709ea0-0908-4bea-8468-433bd706cedd", "ZM", "Zambia", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 125, "40709ea0-0908-4bea-8468-433bd706cedd", "LS", "Lesotho", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 123, "40709ea0-0908-4bea-8468-433bd706cedd", "LV", "Latvia", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 33, "40709ea0-0908-4bea-8468-433bd706cedd", "IO", "British Indian Ocean Territory", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 34, "40709ea0-0908-4bea-8468-433bd706cedd", "BN", "Brunei Darussalam", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 35, "40709ea0-0908-4bea-8468-433bd706cedd", "BG", "Bulgaria", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 36, "40709ea0-0908-4bea-8468-433bd706cedd", "BF", "Burkina Faso", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 37, "40709ea0-0908-4bea-8468-433bd706cedd", "BI", "Burundi", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 38, "40709ea0-0908-4bea-8468-433bd706cedd", "KH", "Cambodia", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 39, "40709ea0-0908-4bea-8468-433bd706cedd", "CM", "Cameroon", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 40, "40709ea0-0908-4bea-8468-433bd706cedd", "CA", "Canada", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 41, "40709ea0-0908-4bea-8468-433bd706cedd", "CV", "Cape Verde", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 42, "40709ea0-0908-4bea-8468-433bd706cedd", "KY", "Cayman Islands", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 43, "40709ea0-0908-4bea-8468-433bd706cedd", "CF", "Central African Republic", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 44, "40709ea0-0908-4bea-8468-433bd706cedd", "TD", "Chad", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 45, "40709ea0-0908-4bea-8468-433bd706cedd", "CL", "Chile", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 46, "40709ea0-0908-4bea-8468-433bd706cedd", "CN", "China", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 47, "40709ea0-0908-4bea-8468-433bd706cedd", "CX", "Christmas Island", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 48, "40709ea0-0908-4bea-8468-433bd706cedd", "CC", "Cocos (Keeling) Islands", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 49, "40709ea0-0908-4bea-8468-433bd706cedd", "CO", "Colombia", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 50, "40709ea0-0908-4bea-8468-433bd706cedd", "KM", "Comoros", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 51, "40709ea0-0908-4bea-8468-433bd706cedd", "CG", "Congo", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 52, "40709ea0-0908-4bea-8468-433bd706cedd", "CD", "Congo, the Democratic Republic of the", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 53, "40709ea0-0908-4bea-8468-433bd706cedd", "CK", "Cook Islands", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 54, "40709ea0-0908-4bea-8468-433bd706cedd", "CR", "Costa Rica", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 55, "40709ea0-0908-4bea-8468-433bd706cedd", "CI", "Côte d\"Ivoire", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 56, "40709ea0-0908-4bea-8468-433bd706cedd", "HR", "Croatia", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 57, "40709ea0-0908-4bea-8468-433bd706cedd", "CU", "Cuba", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 58, "40709ea0-0908-4bea-8468-433bd706cedd", "CW", "Curaçao", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 59, "40709ea0-0908-4bea-8468-433bd706cedd", "CY", "Cyprus", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 32, "40709ea0-0908-4bea-8468-433bd706cedd", "BR", "Brazil", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 60, "40709ea0-0908-4bea-8468-433bd706cedd", "CZ", "Czech Republic", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 31, "40709ea0-0908-4bea-8468-433bd706cedd", "BV", "Bouvet Island", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 29, "40709ea0-0908-4bea-8468-433bd706cedd", "BA", "Bosnia and Herzegovina", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 2, "40709ea0-0908-4bea-8468-433bd706cedd", "AX", "Åland Islands", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 3, "40709ea0-0908-4bea-8468-433bd706cedd", "AL", "Albania", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 4, "40709ea0-0908-4bea-8468-433bd706cedd", "DZ", "Algeria", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 5, "40709ea0-0908-4bea-8468-433bd706cedd", "AS", "American Samoa", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 6, "40709ea0-0908-4bea-8468-433bd706cedd", "AD", "Andorra", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 7, "40709ea0-0908-4bea-8468-433bd706cedd", "AO", "Angola", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 8, "40709ea0-0908-4bea-8468-433bd706cedd", "AI", "Anguilla", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 9, "40709ea0-0908-4bea-8468-433bd706cedd", "AQ", "Antarctica", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 10, "40709ea0-0908-4bea-8468-433bd706cedd", "AG", "Antigua and Barbuda", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 11, "40709ea0-0908-4bea-8468-433bd706cedd", "AR", "Argentina", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 12, "40709ea0-0908-4bea-8468-433bd706cedd", "AM", "Armenia", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 13, "40709ea0-0908-4bea-8468-433bd706cedd", "AW", "Aruba", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 14, "40709ea0-0908-4bea-8468-433bd706cedd", "AU", "Australia", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 15, "40709ea0-0908-4bea-8468-433bd706cedd", "AT", "Austria", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 16, "40709ea0-0908-4bea-8468-433bd706cedd", "AZ", "Azerbaijan", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 17, "40709ea0-0908-4bea-8468-433bd706cedd", "BS", "Bahamas", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 18, "40709ea0-0908-4bea-8468-433bd706cedd", "BH", "Bahrain", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 19, "40709ea0-0908-4bea-8468-433bd706cedd", "BD", "Bangladesh", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 20, "40709ea0-0908-4bea-8468-433bd706cedd", "BB", "Barbados", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 21, "40709ea0-0908-4bea-8468-433bd706cedd", "BY", "Belarus", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 22, "40709ea0-0908-4bea-8468-433bd706cedd", "BE", "Belgium", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 23, "40709ea0-0908-4bea-8468-433bd706cedd", "BZ", "Belize", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 24, "40709ea0-0908-4bea-8468-433bd706cedd", "BJ", "Benin", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 25, "40709ea0-0908-4bea-8468-433bd706cedd", "BM", "Bermuda", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 26, "40709ea0-0908-4bea-8468-433bd706cedd", "BT", "Bhutan", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 27, "40709ea0-0908-4bea-8468-433bd706cedd", "BO", "Bolivia, Plurinational State of", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 28, "40709ea0-0908-4bea-8468-433bd706cedd", "BQ", "Bonaire, Sint Eustatius and Saba", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 30, "40709ea0-0908-4bea-8468-433bd706cedd", "BW", "Botswana", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 61, "40709ea0-0908-4bea-8468-433bd706cedd", "DK", "Denmark", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 62, "40709ea0-0908-4bea-8468-433bd706cedd", "DJ", "Djibouti", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 63, "40709ea0-0908-4bea-8468-433bd706cedd", "DM", "Dominica", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 96, "40709ea0-0908-4bea-8468-433bd706cedd", "HT", "Haiti", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 97, "40709ea0-0908-4bea-8468-433bd706cedd", "HM", "Heard Island and McDonald Islands", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 98, "40709ea0-0908-4bea-8468-433bd706cedd", "VA", "Holy See (Vatican City State)", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 99, "40709ea0-0908-4bea-8468-433bd706cedd", "HN", "Honduras", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 100, "40709ea0-0908-4bea-8468-433bd706cedd", "HK", "Hong Kong", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 101, "40709ea0-0908-4bea-8468-433bd706cedd", "HU", "Hungary", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 102, "40709ea0-0908-4bea-8468-433bd706cedd", "IS", "Iceland", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 103, "40709ea0-0908-4bea-8468-433bd706cedd", "IN", "India", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 104, "40709ea0-0908-4bea-8468-433bd706cedd", "ID", "Indonesia", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 105, "40709ea0-0908-4bea-8468-433bd706cedd", "IR", "Iran, Islamic Republic of", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 106, "40709ea0-0908-4bea-8468-433bd706cedd", "IQ", "Iraq", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 107, "40709ea0-0908-4bea-8468-433bd706cedd", "IE", "Ireland", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 108, "40709ea0-0908-4bea-8468-433bd706cedd", "IM", "Isle of Man", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 109, "40709ea0-0908-4bea-8468-433bd706cedd", "IL", "Israel", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 110, "40709ea0-0908-4bea-8468-433bd706cedd", "IT", "Italy", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 111, "40709ea0-0908-4bea-8468-433bd706cedd", "JM", "Jamaica", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 112, "40709ea0-0908-4bea-8468-433bd706cedd", "JP", "Japan", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 113, "40709ea0-0908-4bea-8468-433bd706cedd", "JE", "Jersey", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 114, "40709ea0-0908-4bea-8468-433bd706cedd", "JO", "Jordan", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 115, "40709ea0-0908-4bea-8468-433bd706cedd", "KZ", "Kazakhstan", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 116, "40709ea0-0908-4bea-8468-433bd706cedd", "KE", "Kenya", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 117, "40709ea0-0908-4bea-8468-433bd706cedd", "KI", "Kiribati", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 118, "40709ea0-0908-4bea-8468-433bd706cedd", "KP", "Korea, Democratic People\"s Republic of", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 119, "40709ea0-0908-4bea-8468-433bd706cedd", "KR", "Korea, Republic of", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 120, "40709ea0-0908-4bea-8468-433bd706cedd", "KW", "Kuwait", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 121, "40709ea0-0908-4bea-8468-433bd706cedd", "KG", "Kyrgyzstan", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 122, "40709ea0-0908-4bea-8468-433bd706cedd", "LA", "Lao People\"s Democratic Republic", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 95, "40709ea0-0908-4bea-8468-433bd706cedd", "GY", "Guyana", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 94, "40709ea0-0908-4bea-8468-433bd706cedd", "GW", "Guinea-Bissau", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 93, "40709ea0-0908-4bea-8468-433bd706cedd", "GN", "Guinea", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 92, "40709ea0-0908-4bea-8468-433bd706cedd", "GG", "Guernsey", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 64, "40709ea0-0908-4bea-8468-433bd706cedd", "DO", "Dominican Republic", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 65, "40709ea0-0908-4bea-8468-433bd706cedd", "EC", "Ecuador", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 66, "40709ea0-0908-4bea-8468-433bd706cedd", "EG", "Egypt", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 67, "40709ea0-0908-4bea-8468-433bd706cedd", "SV", "El Salvador", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 68, "40709ea0-0908-4bea-8468-433bd706cedd", "GQ", "Equatorial Guinea", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 69, "40709ea0-0908-4bea-8468-433bd706cedd", "ER", "Eritrea", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 70, "40709ea0-0908-4bea-8468-433bd706cedd", "EE", "Estonia", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 71, "40709ea0-0908-4bea-8468-433bd706cedd", "ET", "Ethiopia", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 72, "40709ea0-0908-4bea-8468-433bd706cedd", "FK", "Falkland Islands (Malvinas)", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 73, "40709ea0-0908-4bea-8468-433bd706cedd", "FO", "Faroe Islands", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 74, "40709ea0-0908-4bea-8468-433bd706cedd", "FJ", "Fiji", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 75, "40709ea0-0908-4bea-8468-433bd706cedd", "FI", "Finland", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 76, "40709ea0-0908-4bea-8468-433bd706cedd", "FR", "France", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 124, "40709ea0-0908-4bea-8468-433bd706cedd", "LB", "Lebanon", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 77, "40709ea0-0908-4bea-8468-433bd706cedd", "GF", "French Guiana", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 79, "40709ea0-0908-4bea-8468-433bd706cedd", "TF", "French Southern Territories", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 80, "40709ea0-0908-4bea-8468-433bd706cedd", "GA", "Gabon", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 81, "40709ea0-0908-4bea-8468-433bd706cedd", "GM", "Gambia", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 82, "40709ea0-0908-4bea-8468-433bd706cedd", "GE", "Georgia", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 83, "40709ea0-0908-4bea-8468-433bd706cedd", "DE", "Germany", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 84, "40709ea0-0908-4bea-8468-433bd706cedd", "GH", "Ghana", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 85, "40709ea0-0908-4bea-8468-433bd706cedd", "GI", "Gibraltar", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 86, "40709ea0-0908-4bea-8468-433bd706cedd", "GR", "Greece", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 87, "40709ea0-0908-4bea-8468-433bd706cedd", "GL", "Greenland", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 88, "40709ea0-0908-4bea-8468-433bd706cedd", "GD", "Grenada", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 89, "40709ea0-0908-4bea-8468-433bd706cedd", "GP", "Guadeloupe", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 90, "40709ea0-0908-4bea-8468-433bd706cedd", "GU", "Guam", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 91, "40709ea0-0908-4bea-8468-433bd706cedd", "GT", "Guatemala", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 78, "40709ea0-0908-4bea-8468-433bd706cedd", "PF", "French Polynesia", 110, "40709ea0-0908-4bea-8468-433bd706cedd" },
                    { 249, "40709ea0-0908-4bea-8468-433bd706cedd", "ZW", "Zimbabwe", 110, "40709ea0-0908-4bea-8468-433bd706cedd" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "ADM_OCRY",
                keyColumn: "id",
                keyValue: 249);
        }
    }
}
