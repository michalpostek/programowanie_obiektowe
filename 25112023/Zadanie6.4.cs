namespace Zadanie4 {
    class UsedEnergyRegister {
        public double initialUsedEnergy;
        public double totalUsedEnergy;

        public UsedEnergyRegister(double initialValue) {
            initialUsedEnergy = initialValue;
            totalUsedEnergy = initialValue;
        }

        public void RegisterUsedEnergy(double usedEnergy) {
            totalUsedEnergy += usedEnergy;
        }
    }
}