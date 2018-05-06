create view vw_insurance_policy as
select A."Id", A."Name" "PolicyName", A."Description", 
       A."CoverageType", B.name "CoverageTypeName",
	   A."StartDate", A."CoveragePeriod", A."Price",
	   A."RiskType", C.name "RiskTypeName"
from insurance_policy        A inner join
     insurance_coverage_type B on A."CoverageType" = B.coverage_type_id inner join
	 insurance_risk_type     C on A."RiskType" = C.insurance_risk_type;