import React from 'react';
import styles from './CohortDetails.module.css';

function CohortDetails() {
    return (
        <div className={styles.cohortsContainer}>
            <div className={styles.header}>Cohorts Details</div>
            <div className={styles.cardsGrid}>
                {/* Card 1 */}
                <div className={styles.card}>
                    <div className={styles.cohortTitleBlue}>
                        INTADMDIF10 - .NET FSD
                    </div>
                    <div>
                        <span className={styles.label}>Started On</span>
                        <div className={styles.value}>22-Feb-2022</div>
                        <span className={styles.label}>Current Status</span>
                        <div className={styles.value}>Scheduled</div>
                        <span className={styles.label}>Coach</span>
                        <div className={styles.value}>Aathma</div>
                        <span className={styles.label}>Trainer</span>
                        <div className={styles.value}>Jojo Jose</div>
                    </div>
                </div>
                {/* Card 2 */}
                <div className={styles.card}>
                    <div className={styles.cohortTitleGreen}>
                        ADM21JF014 - Java FSD
                    </div>
                    <div>
                        <span className={styles.label}>Started On</span>
                        <div className={styles.value}>10-Sep-2021</div>
                        <span className={styles.label}>Current Status</span>
                        <div className={styles.value}>Ongoing</div>
                        <span className={styles.label}>Coach</span>
                        <div className={styles.value}>Apoorv</div>
                        <span className={styles.label}>Trainer</span>
                        <div className={styles.value}>Elisa Smith</div>
                    </div>
                </div>
                {/* Card 3 */}
                <div className={styles.card}>
                    <div className={styles.cohortTitleGreen}>
                        CDBJF21025 - Java FSD
                    </div>
                    <div>
                        <span className={styles.label}>Started On</span>
                        <div className={styles.value}>24-Dec-2021</div>
                        <span className={styles.label}>Current Status</span>
                        <div className={styles.value}>Ongoing</div>
                        <span className={styles.label}>Coach</span>
                        <div className={styles.value}>Aathma</div>
                        <span className={styles.label}>Trainer</span>
                        <div className={styles.value}>John Doe</div>
                    </div>
                </div>
            </div> 
        </div>
    );
}

export default CohortDetails;
