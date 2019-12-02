ALTER TABLE "CustomerAddress" DROP CONSTRAINT "FK_CustomerAddress_StormyCustomer_StormyCustomerId";

ALTER TABLE "ProductTemplateProductAttribute" DROP CONSTRAINT "FK_ProductTemplateProductAttribute_ProductAttribute_ProductAttributeId";

ALTER TABLE "ProductTemplateProductAttribute" DROP CONSTRAINT "FK_ProductTemplateProductAttribute_ProductTemplate_ProductTemplateId";

ALTER TABLE "StormyCustomer" DROP CONSTRAINT "FK_StormyCustomer_CustomerAddress_DefaultBillingAddressId";

ALTER TABLE "StormyCustomer" DROP CONSTRAINT "FK_StormyCustomer_CustomerAddress_DefaultShippingAddressId";

DROP INDEX "IX_StormyCustomer_DefaultBillingAddressId";

DROP INDEX "IX_StormyCustomer_DefaultShippingAddressId";

ALTER TABLE "StormyCustomer" DROP COLUMN "DefaultBillingAddressId";

ALTER TABLE "StormyCustomer" DROP COLUMN "DefaultShippingAddressId";

ALTER TABLE "CustomerAddress" ADD "IsDefault" boolean NOT NULL DEFAULT FALSE;

ALTER TABLE "CustomerAddress" ADD "StormyCustomerId1" text NULL;

ALTER TABLE "CustomerAddress" ADD "Type" integer NOT NULL DEFAULT 0;

CREATE TABLE config_appsettings (
    "Id" text NOT NULL,
    "Value" text NULL,
    "Module" text NULL,
    "IsVisibleInCommonSettingPage" boolean NOT NULL,
    CONSTRAINT "PK_config_appsettings" PRIMARY KEY ("Id")
);

CREATE INDEX "IX_CustomerAddress_StormyCustomerId1" ON "CustomerAddress" ("StormyCustomerId1");

ALTER TABLE "CustomerAddress" ADD CONSTRAINT "FK_CustomerAddress_StormyCustomer_StormyCustomerId" FOREIGN KEY ("StormyCustomerId") REFERENCES "StormyCustomer" ("Id") ON DELETE CASCADE;

ALTER TABLE "CustomerAddress" ADD CONSTRAINT "FK_CustomerAddress_StormyCustomer_StormyCustomerId1" FOREIGN KEY ("StormyCustomerId1") REFERENCES "StormyCustomer" ("Id") ON DELETE RESTRICT;

ALTER TABLE "ProductTemplateProductAttribute" ADD CONSTRAINT "FK_ProductTemplateProductAttribute_ProductAttribute_ProductAtt~" FOREIGN KEY ("ProductAttributeId") REFERENCES "ProductAttribute" ("Id") ON DELETE CASCADE;

ALTER TABLE "ProductTemplateProductAttribute" ADD CONSTRAINT "FK_ProductTemplateProductAttribute_ProductTemplate_ProductTemp~" FOREIGN KEY ("ProductTemplateId") REFERENCES "ProductTemplate" ("Id") ON DELETE RESTRICT;

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20191202011342_UpdatingAddress', '2.2.6-servicing-10079');

