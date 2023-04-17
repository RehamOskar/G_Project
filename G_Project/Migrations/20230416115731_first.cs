using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace G_Project.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "importers",
                columns: table => new
                {
                    ImporterID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActualName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameDocuments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_importers", x => x.ImporterID);
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    ProdectID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommodityType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TradeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameProducingCompany = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryOrigin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BatchNumber = table.Column<int>(type: "int", nullable: false),
                    ProductionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PackageType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrductWeight = table.Column<float>(type: "real", nullable: false),
                    Size = table.Column<float>(type: "real", nullable: false),
                    Measure = table.Column<float>(type: "real", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false),
                    ImpotedQuantityItem = table.Column<int>(type: "int", nullable: false),
                    Matching = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfSampleUnitsDrawn = table.Column<int>(type: "int", nullable: false),
                    ResultOfPrevioousExaminationReport = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ValidityPeriods = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StatementCard = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExaminationNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.ProdectID);
                });

            migrationBuilder.CreateTable(
                name: "projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Level = table.Column<int>(type: "int", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_projects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "shipments",
                columns: table => new
                {
                    ShipmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShipmentNumberMade = table.Column<int>(type: "int", nullable: false),
                    ShipmentArrivalDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Location_Of_ItemsMade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Number_Of_ItemsMade = table.Column<int>(type: "int", nullable: false),
                    Number_Of_Items_For_Examination = table.Column<int>(type: "int", nullable: false),
                    TotalQuantityMade = table.Column<int>(type: "int", nullable: false),
                    TotalQuantityItemsMade = table.Column<int>(type: "int", nullable: false),
                    TotalOfShipment = table.Column<int>(type: "int", nullable: false),
                    ShipmentData = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateReceiptShipment = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Number_Of_Transportation = table.Column<int>(type: "int", nullable: false),
                    TransportationID = table.Column<int>(type: "int", nullable: false),
                    TransportationType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReportNumber = table.Column<int>(type: "int", nullable: false),
                    ReportDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Date_Of_CustomDeclaration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Number_Of__CustomDeclaration = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shipments", x => x.ShipmentID);
                });

            migrationBuilder.CreateTable(
                name: "startOfActivities",
                columns: table => new
                {
                    IdStartA = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Result = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Purpose = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_startOfActivities", x => x.IdStartA);
                });

            migrationBuilder.CreateTable(
                name: "startOfProductions",
                columns: table => new
                {
                    IdStartP = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdInvestor = table.Column<int>(type: "int", nullable: false),
                    Purpose = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeOfActivityPeriod = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_startOfProductions", x => x.IdStartP);
                });

            migrationBuilder.CreateTable(
                name: "TypesOfProducts",
                columns: table => new
                {
                    TypesOfProductsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeOfProduct = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TradeMark = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductionCapacity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductRegistration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypesOfProductsId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypesOfProducts", x => x.TypesOfProductsId);
                    table.ForeignKey(
                        name: "FK_TypesOfProducts_TypesOfProducts_TypesOfProductsId1",
                        column: x => x.TypesOfProductsId1,
                        principalTable: "TypesOfProducts",
                        principalColumn: "TypesOfProductsId");
                });

            migrationBuilder.CreateTable(
                name: "VirtualExmination",
                columns: table => new
                {
                    VirtualExaminationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProdectID = table.Column<int>(type: "int", nullable: false),
                    ExaminationName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VirtualExmination", x => x.VirtualExaminationId);
                    table.ForeignKey(
                        name: "FK_VirtualExmination_products_ProdectID",
                        column: x => x.ProdectID,
                        principalTable: "products",
                        principalColumn: "ProdectID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "descentDatas",
                columns: table => new
                {
                    DescentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id = table.Column<int>(type: "int", nullable: false),
                    DescentTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Day = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescentDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_descentDatas", x => x.DescentId);
                    table.ForeignKey(
                        name: "FK_descentDatas_projects_Id",
                        column: x => x.Id,
                        principalTable: "projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sampleInspections",
                columns: table => new
                {
                    SampleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Purpose = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Result = table.Column<int>(type: "int", nullable: false),
                    Matching = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomsDeclaration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShipmentId = table.Column<int>(type: "int", nullable: false),
                    ImporterId = table.Column<int>(type: "int", nullable: false),
                    ProdectID = table.Column<int>(type: "int", nullable: false),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    Document = table.Column<int>(type: "int", nullable: false),
                    TradeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EditingReportNumber = table.Column<int>(type: "int", nullable: false),
                    EditingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NotchedSide = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Purpose_Of_Scoring = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DetectiveInspectore = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sampleInspections", x => x.SampleId);
                    table.ForeignKey(
                        name: "FK_sampleInspections_importers_ImporterId",
                        column: x => x.ImporterId,
                        principalTable: "importers",
                        principalColumn: "ImporterID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sampleInspections_projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sampleInspections_shipments_ShipmentId",
                        column: x => x.ShipmentId,
                        principalTable: "shipments",
                        principalColumn: "ShipmentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "productInProductions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypesOfProductsId = table.Column<int>(type: "int", nullable: false),
                    IdStartP = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productInProductions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_productInProductions_startOfProductions_IdStartP",
                        column: x => x.IdStartP,
                        principalTable: "startOfProductions",
                        principalColumn: "IdStartP",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_productInProductions_TypesOfProducts_TypesOfProductsId",
                        column: x => x.TypesOfProductsId,
                        principalTable: "TypesOfProducts",
                        principalColumn: "TypesOfProductsId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_descentDatas_Id",
                table: "descentDatas",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_productInProductions_IdStartP",
                table: "productInProductions",
                column: "IdStartP");

            migrationBuilder.CreateIndex(
                name: "IX_productInProductions_TypesOfProductsId",
                table: "productInProductions",
                column: "TypesOfProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_sampleInspections_ImporterId",
                table: "sampleInspections",
                column: "ImporterId");

            migrationBuilder.CreateIndex(
                name: "IX_sampleInspections_ProjectId",
                table: "sampleInspections",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_sampleInspections_ShipmentId",
                table: "sampleInspections",
                column: "ShipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_TypesOfProducts_TypesOfProductsId1",
                table: "TypesOfProducts",
                column: "TypesOfProductsId1");

            migrationBuilder.CreateIndex(
                name: "IX_VirtualExmination_ProdectID",
                table: "VirtualExmination",
                column: "ProdectID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "descentDatas");

            migrationBuilder.DropTable(
                name: "productInProductions");

            migrationBuilder.DropTable(
                name: "sampleInspections");

            migrationBuilder.DropTable(
                name: "startOfActivities");

            migrationBuilder.DropTable(
                name: "VirtualExmination");

            migrationBuilder.DropTable(
                name: "startOfProductions");

            migrationBuilder.DropTable(
                name: "TypesOfProducts");

            migrationBuilder.DropTable(
                name: "importers");

            migrationBuilder.DropTable(
                name: "projects");

            migrationBuilder.DropTable(
                name: "shipments");

            migrationBuilder.DropTable(
                name: "products");
        }
    }
}
